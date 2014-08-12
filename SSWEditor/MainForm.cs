using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VDS.RDF;
using VDS.RDF.Configuration;
using VDS.RDF.Parsing;
using VDS.RDF.Storage;
using VDS.RDF.Writing;

namespace SSWEditor
{
    public partial class MainForm : Form
    {
        public static String documentRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SSWEditor";
        public static Config config = new Config();
        public static FusekiConnector fuseki; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateApplication();
            closeGraphToolStripMenuItem.Enabled = false;

            try
            {
                if (!Directory.Exists(documentRoot)) Directory.CreateDirectory(documentRoot);
            }
            catch
            {
                MessageBox.Show("error during document root creation");
            }


            LoadConfig();

            string installPath = GetJavaInstallationPath();
            string javaPath = System.IO.Path.Combine(installPath, "bin\\Java.exe");
            if (!System.IO.File.Exists(javaPath))
            {
                if (MessageBox.Show(string.Format("Java is not installted. Do you install java?")
                    , "Infomation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Process.Start("http://www.oracle.com/technetwork/java/javase/downloads/index.html");
                }
                Application.Exit();
            }


            try
            {
                Fuseki.Start(MainForm.config.ShowFusekiConsole);
                fuseki = new FusekiConnector("http://localhost:" + config.FusekiPort + "/ds/data");

                if (!CheckFusekiConnection())
                {
                    Thread.Sleep(1000);
                    for (int i = 1; i <= 3 && !CheckFusekiConnection(); i++)
                    {
                        if (MessageBox.Show(string.Format("Fuseki server is not ready. Retry to connect ({0})", i)
                            , "Infomation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) break;
                    }
                }
                if (!CheckFusekiConnection())
                {
                    MessageBox.Show("Fuseki server is not ready. Exit the application.");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during building connection to fuseki server"+ex);
            }
            UpdateListViewGraph();
        }

        public static string GetJavaInstallationPath()
        {
            string environmentPath = Environment.GetEnvironmentVariable("JAVA_HOME");
            if (!string.IsNullOrEmpty(environmentPath))
            {
                return environmentPath;
            }

            string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment\\";
            using (Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(javaKey))
            {
                string currentVersion = rk.GetValue("CurrentVersion").ToString();
                using (Microsoft.Win32.RegistryKey key = rk.OpenSubKey(currentVersion))
                {
                    return key.GetValue("JavaHome").ToString();
                }
            }
        }


        public static string currVersion = "offline";
        public static void UpdateApplication(bool force=false)
        {
            try
            {
                currVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                UpdateCheckInfo updateCheckInfo = ApplicationDeployment.CurrentDeployment.CheckForDetailedUpdate(false);
                if (updateCheckInfo.UpdateAvailable)
                {
                    if (MessageBox.Show(string.Format("There is a new version {0}. Do you want to update the application to the lastest version?", updateCheckInfo.AvailableVersion.ToString())
                        , "Information", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ApplicationDeployment.CurrentDeployment.Update();
                        MessageBox.Show("Updating is completed. Now, restart the application.");
                        Application.Restart();
                    }
                }
            }
            catch
            {
                if (force)
                {
                    MessageBox.Show(string.Format("There is no update available."));
                }
            }
        }
        
        public static void LoadConfig()
        {
            if (File.Exists(documentRoot + @"\config.xml"))
            {
                try
                {
                    XmlSerializer m = new XmlSerializer(config.GetType());
                    System.IO.TextReader r = new System.IO.StreamReader(documentRoot + @"\config.xml");
                    config = (Config)m.Deserialize(r);
                    r.Close();
                }
                catch 
                {
                    if ( MessageBox.Show("Warning", "config.xml is invalid. Do you recreate the config.xml?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                        SaveConfig();
                    } 
                }
            }
            else
            {
                string randomString = Config.GetRandomString(6);
                SingleForm form = new SingleForm();
                form.title = "Set unique userid";
                form.label = "userid";
                form.content = randomString;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    config.GlobalPrefix = string.Format("http://ah.withcat.net/{0}/", form.content);
                }
                else
                {
                    config.GlobalPrefix = string.Format("http://ah.withcat.net/{0}/", randomString);
                }
                SaveConfig();
            }
        }

        public static void SaveConfig()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(config.GetType());
                System.IO.StreamWriter sw = new System.IO.StreamWriter(documentRoot + @"\config.xml", false);
                xs.Serialize(sw, config);
                sw.Close();
            }
            catch 
            {
                MessageBox.Show("error during config.xml creation");
            }
        }

        private bool CheckFusekiConnection()
        {
            try
            {
                fuseki.ListGraphs();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void UpdateListViewGraph()
        {
            try
            {
                listViewGraph.Items.Clear();

                List<string> graphs = new List<string>();
                graphs.Add("default");
                foreach (Uri uri in fuseki.ListGraphs())
                {
                    graphs.Add(uri.ToString());
                }
                foreach (string uri in graphs)
                {
                    string graphBase64 = GraphEditor.Base64Encode(uri);
                    string filePath = string.Format(@"{0}\{1}.txt", documentRoot, graphBase64);
                    string updateDate = "";
                    if (File.Exists(filePath))
                    {
                        FileInfo info = new FileInfo(filePath);
                        updateDate = info.LastWriteTime.ToShortDateString();
                    }

                    ListViewItem item = new ListViewItem(new string[] { uri, updateDate });
                    item.Tag = uri;
                    listViewGraph.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during UpdateListViewGraph. "+ex);
            }
        }

        private void listViewGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1) return;
            string uri = (string)listViewGraph.SelectedItems[0].Tag;

             TabPage tabpage = GetTabPage(uri);
            if (tabpage == null)
            {
                tabpage = new TabPage(uri);
                GraphEditor graphEditor = new GraphEditor();
                graphEditor.SetGraph(uri);
                graphEditor.Dock = DockStyle.Fill;
                tabpage.Controls.Add(graphEditor);
                tabpage.Tag = graphEditor;

                tabControlGraph.TabPages.Add(tabpage);

                closeGraphToolStripMenuItem.Enabled = true;
            }
            tabControlGraph.SelectedTab = tabpage;
        }

        private TabPage GetTabPage(string uri)
        {
            TabPage tabpage = null;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                if (page.Text == uri) tabpage = page;
            }
            return tabpage;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fuseki.Stop();
        }

        /// <summary>
        /// make new graph
        /// https://bitbucket.org/dotnetrdf/dotnetrdf/wiki/UserGuide/Triple%20Store%20Integration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SingleForm form = new SingleForm();
                form.title = "New Graph";
                form.label = "URI";
                form.content = config.GlobalPrefix + Config.GetRandomString(6);

                if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

                string uri = form.content;
                Graph g = new Graph();
                g.BaseUri = new Uri(uri);
                SetNewGraph(g, uri);
                fuseki.SaveGraph(g);

                UpdateListViewGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during creating new graph. " + ex);
            }
        }

        private void SetNewGraph(Graph g, string uri)
        {
            string label = uri.Split(new char[] { '/', '#' }).Last();
            string nt = string.Format("<{0}> <{1}> \"{2}\"."
                , uri
                , "http://www.w3.org/2000/01/rdf-schema#label"
                , label);
            StringParser.Parse(g, nt);
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preference form = new Preference();
            form.ShowDialog();
        }

        private void closeGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( tabControlGraph.TabPages.Count == 0 ) return;

            GraphEditor graphEditor = (GraphEditor)tabControlGraph.SelectedTab.Tag;
            if (graphEditor.RequestSave())
            {
                if (MessageBox.Show(string.Format("save graph before closing graph {0}", graphEditor.graphUri), "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    graphEditor.SaveGraph();
                }
            }

            int removeIdx = tabControlGraph.SelectedIndex;
            tabControlGraph.TabPages.Remove(tabControlGraph.SelectedTab);
            if (removeIdx == tabControlGraph.TabPages.Count)
            {
                removeIdx--;
            }
            if (removeIdx >= 0)
            {
                tabControlGraph.SelectedIndex = removeIdx;
            }
            if (tabControlGraph.TabPages.Count == 0)
            {
                closeGraphToolStripMenuItem.Enabled = false;
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
        }

        private void CloseAllTabs()
        {
            if (tabControlGraph.TabPages.Count == 0) return;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                GraphEditor graphEditor = (GraphEditor)tabControlGraph.SelectedTab.Tag;
                if (graphEditor.RequestSave())
                {
                    if (MessageBox.Show(string.Format("save graph before closing graph {0}", graphEditor.graphUri), "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        graphEditor.SaveGraph();
                    }
                }
            }
            tabControlGraph.TabPages.Clear();
        }

       
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateListViewGraph();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplication(true);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadingForm form = new LoadingForm();
            form.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlGraph.TabPages.Count == 0) return;
            GraphEditor graphEditor = (GraphEditor)tabControlGraph.SelectedTab.Tag;
            graphEditor.SaveGraph();
            UpdateListViewGraph();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlGraph.TabPages.Count == 0) return;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                GraphEditor graphEditor = (GraphEditor)page.Tag;
                graphEditor.SaveGraph();
            }
            UpdateListViewGraph();
        }

     
        private void fromFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1)
            {
                MessageBox.Show("no graph is selected");
                return;
            }
            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;
            TabPage tabPage = GetTabPage(graphUri);
            if (tabPage != null)
            {
                GraphEditor graphEditor = (GraphEditor)tabPage.Tag;
                if (graphEditor.RequestSave())
                {
                    if (MessageBox.Show(string.Format("save graph before closing graph {0}", graphEditor.graphUri), "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        graphEditor.SaveGraph();
                    }
                }
                tabControlGraph.TabPages.Remove(tabPage);
            }
            
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != System.Windows.Forms.DialogResult.OK) return;

            string path = openFileDialog1.FileName;
            string ext = Path.GetExtension(path).ToLower();

            Graph ng = new Graph();
            try
            {
                if (ext == ".ttl")
                {
                    new TurtleParser().Load(ng, path);
                }
                else if (ext == ".nt")
                {
                    new NTriplesParser().Load(ng, path);
                }
                else if (ext == ".rdf")
                {
                    FileLoader.Load(ng, path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format. "+ex);
                return;
            }

            Graph g = new Graph();
            fuseki.LoadGraph(g, graphUri);
            int cnt = 0;
            foreach (var t in ng.Triples)
            {
                if (g.Assert(t)) cnt++;
            }
            fuseki.SaveGraph(g);
            MessageBox.Show(string.Format("successfully load {0} triples", cnt)); 
        }

        private void fromURIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1)
            {
                MessageBox.Show("no graph is selected");
                return;
            }
            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;
            TabPage tabPage = GetTabPage(graphUri);
            if (tabPage != null)
            {
                GraphEditor graphEditor = (GraphEditor)tabPage.Tag;
                if (graphEditor.RequestSave())
                {
                    if (MessageBox.Show(string.Format("save graph before closing graph {0}", graphEditor.graphUri), "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        graphEditor.SaveGraph();
                    }
                }
                tabControlGraph.TabPages.Remove(tabPage);
            }

            SingleForm form = new SingleForm();
            form.title = "Set URI";
            form.label = "URI";
            if (form.ShowDialog() != DialogResult.OK) return;

            Graph ng = new Graph();
            try
            {
                UriLoader.Load(ng, new Uri(form.content));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format. " + ex);
                return;
            }

            Graph g = new Graph();
            fuseki.LoadGraph(g, graphUri);
            int cnt = 0;
            foreach (var t in ng.Triples)
            {
                if ( g.Assert(t) ) cnt++;
            }
            fuseki.SaveGraph(g);
            MessageBox.Show(string.Format("successfully insert {0} triples", cnt)); 
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1)
            {
                MessageBox.Show("no graph is selected");
                return;
            }
            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;


            var dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult != System.Windows.Forms.DialogResult.OK) return;

            string path = saveFileDialog1.FileName;
            string ext = Path.GetExtension(path).ToLower();

            Graph g = new Graph();
            fuseki.LoadGraph(g, graphUri); 
            try
            {
                if (ext == ".ttl")
                {
                    new CompressingTurtleWriter().Save(g, path);
                }
                else if (ext == ".nt")
                {
                    new NTriplesWriter().Save(g, path);
                }
                else if (ext == ".rdf")
                {
                    new RdfXmlWriter().Save(g, path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid format. " + ex);
                return;
            }
            MessageBox.Show(string.Format("successfully export {0} triples", g.Triples.Count)); 
        }

        private void truncateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1)
            {
                MessageBox.Show("no graph is selected");
                return;
            }
            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;
            if (MessageBox.Show(string.Format("are you want to truncate {0}", graphUri), "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            TabPage tabPage = GetTabPage(graphUri);
            if (tabPage != null)
            {
                tabControlGraph.TabPages.Remove(tabPage);
            }

            Graph g = new Graph();
            fuseki.LoadGraph(g, graphUri);
            g.Clear();
            SetNewGraph(g, graphUri);
            fuseki.SaveGraph(g);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1)
            {
                MessageBox.Show("no graph is selected");
                return;
            } 

            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;
            if (graphUri == "default")
            {
                MessageBox.Show("default(unnamed) graph cannot delete");
                return;
            }
            if (MessageBox.Show(string.Format("are you want to delete {0}", graphUri), "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            TabPage tabPage = GetTabPage(graphUri);
            if (tabPage != null)
            {
                tabControlGraph.TabPages.Remove(tabPage);
            }

            fuseki.DeleteGraph(graphUri);
            UpdateListViewGraph();

            TabPage tabpage = null;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                if (page.Text == graphUri) tabpage = page;
            }

            if (tabpage != null)
            {
                tabControlGraph.TabPages.Remove(tabpage);
                if (tabControlGraph.TabPages.Count == 0)
                {
                    closeGraphToolStripMenuItem.Enabled = false;
                }
            }

        }

    }

  
}
