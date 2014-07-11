using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VDS.RDF;
using VDS.RDF.Configuration;
using VDS.RDF.Parsing;
using VDS.RDF.Storage;

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
            Fuseki.Start();

            try
            {
                fuseki = new FusekiConnector("http://localhost:" + config.FusekiPort + "/ds/data");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during building connection to fuseki server"+ex);
            }
            UpdateListViewGraph();
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
                NewForm form = new NewForm();
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
                    string filePath = string.Format(@"{0}\{1}.xml", documentRoot, graphBase64);
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

            TabPage tabpage = null;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                if ((string)page.Tag == uri) tabpage = page;
            }

            if (tabpage == null)
            {
                tabpage = new TabPage(uri);
                GraphEditor graphEditor = new GraphEditor();
                graphEditor.SetGraph(uri);
                graphEditor.Dock = DockStyle.Fill;
                tabpage.Controls.Add(graphEditor);
                tabpage.Tag = uri;

                tabControlGraph.TabPages.Add(tabpage);

                closeGraphToolStripMenuItem.Enabled = true;
            }
            tabControlGraph.SelectedTab = tabpage;
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
                NewForm form = new NewForm();
                form.title = "New Graph";
                form.label = "URI";
                form.content = config.GlobalPrefix + Config.GetRandomString(6);

                if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

                string uri = form.content;
                string label = uri.Split(new char[] {'/', '#'}).Last();
                string nt = string.Format("<{0}> <{1}> \"{2}\"."
                    , uri
                    , "http://www.w3.org/2000/01/rdf-schema#label"
                    , label);

                Graph g = new Graph();
                StringParser.Parse(g, nt);
                g.BaseUri = new Uri(uri);
                fuseki.SaveGraph(g);

                UpdateListViewGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during creating new graph. " + ex);
            }
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preference form = new Preference();
            form.ShowDialog();
        }

        private void closeGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( tabControlGraph.TabPages.Count == 0 ) return;
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewGraph.SelectedItems.Count != 1) return;
            string graphUri = (string)listViewGraph.SelectedItems[0].Tag;

            if (graphUri == "default")
            {
                MessageBox.Show("default(unnamed) graph cannot delete");
                return;
            }
            if (MessageBox.Show(string.Format("are you want to delete {0}", graphUri), "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            fuseki.DeleteGraph(graphUri);
            UpdateListViewGraph();

            TabPage tabpage = null;
            foreach (TabPage page in tabControlGraph.TabPages)
            {
                if ((string)page.Tag == graphUri) tabpage = page;
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
            MessageBox.Show("not implemented");
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
            Application.Exit();
        }
    }

  
}
