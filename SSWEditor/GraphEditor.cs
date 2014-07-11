using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Configuration;
using VDS.RDF.Parsing;
using VDS.RDF.Storage;
using System.IO;
using VDS.RDF.Writing;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace SSWEditor
{
    public partial class GraphEditor : UserControl
    {
        public string graphUri;
        public string graphBase64;
        public Graph g = new Graph();

        private enum EditingContent { updating, none, text, tuple, table };
        private EditingContent editingContent = EditingContent.none;

        public GraphEditor()
        {
            InitializeComponent();
        }

        public void SetGraph(string uri)
        {
            string loadUri = ""; 
            if (uri == "default")
            {
                loadUri = "";
                graphUri = MainForm.config.GlobalPrefix + "default";
            }
            else
            {
                loadUri = uri;
                graphUri = uri;
            }
            MainForm.fuseki.LoadGraph(g, loadUri);
            graphBase64 = Base64Encode(uri);

            editingContent = EditingContent.updating;
            ShowTextEditor();
            ShowTupleEditor();
            ShowTableEditor();
            editingContent = EditingContent.none;

            Dictionary<string, string> args = new Dictionary<string, string>();
            args["name"] = "SSWEditor";
            args["abbreviation"] = "sswe";
            args["description"] = "Endpoint of the Simple Semantic Web Editor.";
            args["endpointURI"] = "http://localhost:3030/ds";
            args["dontAppendSPARQL"] = "false";
            args["defaultGraphURI"] = loadUri;
            args["isVirtuoso"] = "false";
            args["useProxy"] = "false";
            args["method"] = "POST";
            args["autocompleteLanguage"] = "en";
            args["autocompleteURIs"] = "http://www.w3.org/2000/01/rdf-schema#label";
            args["ignoredProperties"] = "";
            args["abstractURIs"] = "";
            args["imageURIs"] = "";
            args["linkURIs"] = "";
            args["maxRelationLegth"] = "0";

            List<string> encodedArgs = new List<string>();
            foreach (var kv in args)
            {
                encodedArgs.Add(kv.Key + "=" + Base64Encode(kv.Value));
            }
            string relFinderUrl = "http://localhost:3030/RelFinder.swf?" + string.Join("&", encodedArgs);
            webBrowserRelfinder.Navigate(relFinderUrl);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void ShowTextEditor()
        {
            string filePath = string.Format(@"{0}\{1}.xml", MainForm.documentRoot, graphBase64);
            if (File.Exists(filePath))
            {
                textBoxTextEditor.Text = File.ReadAllText(filePath);
            }
        }

        private void ShowTupleEditor()
        {
            Notation3Writer w = new Notation3Writer();
            string data = VDS.RDF.Writing.StringWriter.Write(g, w);
            textBoxTurtleEditor.Text = data;
        }

        private void ShowTableEditor()
        {
            dataGridTableEditor.Rows.Clear();
            foreach (var spo in g.Triples)
            {
                dataGridTableEditor.Rows.Add(new string[] { spo.Subject.ToString(), spo.Predicate.ToString(), spo.Object.ToString() });
            }
        }

        private void UpdateEditor()
        {
            if (editingContent == EditingContent.updating) return;
            if (editingContent == EditingContent.none) return;

            if (editingContent == EditingContent.text)
            {
                UpdateTextEditor();
                editingContent = EditingContent.updating;
                ShowTupleEditor();
                ShowTableEditor();
                editingContent = EditingContent.none;
            }
            else if (editingContent == EditingContent.tuple)
            {
                UpdateTupleEditor();
                editingContent = EditingContent.updating;
                ShowTextEditor();
                ShowTableEditor();
                editingContent = EditingContent.none;
            }
            else if (editingContent == EditingContent.table)
            {
                UpdateTableEditor();
                editingContent = EditingContent.updating;
                ShowTextEditor();
                ShowTupleEditor();
                editingContent = EditingContent.none;
            }
        }

        private void UpdateTextEditor()
        {
            g.Clear();
            string[] lines = textBoxTextEditor.Text.Split(new char[] { '\n' });

            IUriNode nLabel = g.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"));
            List<string> parentList = new List<string>();
            parentList.Add(graphUri);
            foreach (string line in lines)
            {
                string obj = line.TrimEnd();
                int tab = 0;
                Match lSpaceMatch = Regex.Match(obj, @"^[\s]+");
                if (lSpaceMatch.Success)
                {
                    tab = lSpaceMatch.Length / 4;
                }
                obj = obj.TrimStart();
                if (obj == "") continue;

                char[] objChars = obj.ToCharArray();
                List<string> predicateList = new List<string>();
                MatchCollection rPredicateMatchs = Regex.Matches(obj, @"\@(.+?\b)");
                foreach (Match rPredicateMatch in rPredicateMatchs)
                {
                    for (int i = rPredicateMatch.Index; i < rPredicateMatch.Index + rPredicateMatch.Length; i++)
                    {
                        objChars[i] = ' ';
                    }
                    predicateList.Add(string.Format("{0}p#{1}", MainForm.config.GlobalPrefix, rPredicateMatch.Value.Substring(1)));
                }
                obj = string.Join("", objChars).Trim();

                if (predicateList.Count == 0)
                {
                    predicateList.Add("http://rdfs.org/sioc/ns#container_of");
                }

                string currUri = "", currLabel = "";
                if (obj[0] == '#')
                {
                    currUri = string.Format("{0}s#{1}", MainForm.config.GlobalPrefix, obj.Substring(1).Trim());
                    currLabel = obj.Substring(1);
                }
                else
                {
                    Uri tryUri;
                    if (Uri.TryCreate(obj, UriKind.Absolute, out tryUri))
                    {
                        currUri = tryUri.ToString();
                        currLabel = currUri;
                    }
                    else
                    {
                        string objUri = obj;
                        if (objUri.Length > 255) objUri = objUri.Substring(0, 255);
                        objUri = Uri.EscapeUriString(obj);
                        currUri = string.Format("{0}/s#{1}", graphUri, objUri);
                        currLabel = obj;
                    }
                }

                while (parentList.Count >= tab + 2)
                {
                    parentList.RemoveAt(parentList.Count - 1);
                }
                string parentUri = parentList.Last();

                foreach (string predicateUri in predicateList)
                {
                    IUriNode nS = g.CreateUriNode(UriFactory.Create(parentUri));
                    IUriNode nP = g.CreateUriNode(UriFactory.Create(predicateUri));
                    IUriNode nO = g.CreateUriNode(UriFactory.Create(currUri));
                    g.Assert(new Triple(nS, nP, nO));

                    ILiteralNode nLabelVal = g.CreateLiteralNode(currLabel);
                    g.Assert(new Triple(nO, nLabel, nLabelVal));
                }
                parentList.Add(currUri);
            }
        }

        private void UpdateTupleEditor()
        {
            g.Clear();
            TurtleParser parser = new TurtleParser();
            TextReader sr = new StringReader(textBoxTurtleEditor.Text);
            parser.Load(g, sr);
        }

        private void UpdateTableEditor()
        {
            g.Clear();
            for (int i = 0; i < dataGridTableEditor.Rows.Count; i++)
            {
                var row = dataGridTableEditor.Rows[i];
                string s, p, o;
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null) continue;
                s = row.Cells[0].Value.ToString();
                p = row.Cells[1].Value.ToString();
                o = row.Cells[2].Value.ToString();
                Triple triple;
                IUriNode ns = g.CreateUriNode(UriFactory.Create(s));
                IUriNode np = g.CreateUriNode(UriFactory.Create(p));
                Uri tryUri;
                if (Uri.TryCreate(o, UriKind.Absolute, out tryUri))
                {
                    IUriNode no = g.CreateUriNode(UriFactory.Create(o));
                    triple = new Triple(ns, np, no);
                }
                else
                {
                    ILiteralNode no = g.CreateLiteralNode(o);
                    triple = new Triple(ns, np, no);
                }
                g.Assert(triple);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateEditor();

            string filePath = string.Format(@"{0}\{1}.xml", MainForm.documentRoot, graphBase64);
            File.WriteAllText(filePath, textBoxTextEditor.Text);
            MainForm.fuseki.SaveGraph(g);

            MessageBox.Show("graph is saved");
        }

        private void textBoxTextEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (editingContent == EditingContent.updating) return;
            if (editingContent == EditingContent.none) editingContent = EditingContent.text;
        }

        private void textBoxTurtleEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (editingContent == EditingContent.updating) return;
            if (editingContent == EditingContent.none) editingContent = EditingContent.tuple;
        }

        private void dataGridTableEditor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (editingContent == EditingContent.updating) return;
            if (editingContent == EditingContent.none) editingContent = EditingContent.table;
        }

        private void textBoxTextEditor_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            var tb = (FastColoredTextBox)sender;
            tb.SyntaxHighlighter.InitStyleSchema(Language.HTML);
            tb.SyntaxHighlighter.HTMLSyntaxHighlight(tb.Range);
        }

        private void textBoxTurtleEditor_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            var tb = (FastColoredTextBox)sender;
            tb.SyntaxHighlighter.InitStyleSchema(Language.HTML);
            tb.SyntaxHighlighter.HTMLSyntaxHighlight(tb.Range);

        }


        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditor();
        }

        private void dataGridTableEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewTextBoxCell cell in dataGridTableEditor.SelectedCells)
                {
                    cell.Value = "";
                }
            }
            else if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))
            {
                PasteTSV((DataGridView)dataGridTableEditor);
            }
        }

        public static void PasteTSV(DataGridView grid)
        {
            char[] rowSplitter = { '\r', '\n' };
            char[] columnSplitter = { '\t' };

            // Get the text from clipboard
            IDataObject dataInClipboard = Clipboard.GetDataObject();
            string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

            // Split it into lines
            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

            // Get the row and column of selected cell in grid
            int r = grid.SelectedCells[0].RowIndex;
            int c = grid.SelectedCells[0].ColumnIndex;

            // Add rows into grid to fit clipboard lines
            if (grid.Rows.Count < (r + rowsInClipboard.Length))
            {
                grid.Rows.Add(r + rowsInClipboard.Length - grid.Rows.Count);
            }

            // Loop through the lines, split them into cells and place the values in the corresponding cell.
            for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
            {
                // Split row into cell values
                string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                // Cycle through cell values
                for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                {

                    // Assign cell value, only if it within columns of the grid
                    if (grid.ColumnCount - 1 >= c + iCol)
                    {
                        DataGridViewCell cell = grid.Rows[r + iRow].Cells[c + iCol];

                        if (!cell.ReadOnly)
                        {
                            cell.Value = valuesInRow[iCol];
                        }
                    }
                }
            }
        }

    }
}
