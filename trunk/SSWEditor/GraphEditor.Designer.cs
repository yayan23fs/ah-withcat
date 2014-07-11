namespace SSWEditor
{
    partial class GraphEditor
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTextEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.documentMapTextEditor = new FastColoredTextBoxNS.DocumentMap();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxTurtleEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.documentMapTurtleEditor = new FastColoredTextBoxNS.DocumentMap();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridTableEditor = new System.Windows.Forms.DataGridView();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.webBrowserRelfinder = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dataGridViewSPARQL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonChangeGraphUri = new System.Windows.Forms.Button();
            this.textBoxGraphUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTextEditor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTurtleEditor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableEditor)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPARQL)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 25);
            this.panel1.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(367, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 25);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(442, 293);
            this.tabControl3.TabIndex = 4;
            this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabControl3_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(434, 267);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Text Editor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTextEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.documentMapTextEditor);
            this.splitContainer1.Size = new System.Drawing.Size(428, 261);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxTextEditor
            // 
            this.textBoxTextEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBoxTextEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.textBoxTextEditor.BackBrush = null;
            this.textBoxTextEditor.CharHeight = 15;
            this.textBoxTextEditor.CharWidth = 7;
            this.textBoxTextEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTextEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTextEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxTextEditor.IsReplaceMode = false;
            this.textBoxTextEditor.Location = new System.Drawing.Point(0, 0);
            this.textBoxTextEditor.Name = "textBoxTextEditor";
            this.textBoxTextEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.textBoxTextEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.textBoxTextEditor.Size = new System.Drawing.Size(260, 261);
            this.textBoxTextEditor.TabIndex = 0;
            this.textBoxTextEditor.Zoom = 100;
            this.textBoxTextEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxTextEditor_TextChanged);
            this.textBoxTextEditor.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxTextEditor_TextChangedDelayed);
            // 
            // documentMapTextEditor
            // 
            this.documentMapTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentMapTextEditor.ForeColor = System.Drawing.Color.Maroon;
            this.documentMapTextEditor.Location = new System.Drawing.Point(0, 0);
            this.documentMapTextEditor.Name = "documentMapTextEditor";
            this.documentMapTextEditor.Size = new System.Drawing.Size(164, 261);
            this.documentMapTextEditor.TabIndex = 0;
            this.documentMapTextEditor.Target = this.textBoxTextEditor;
            this.documentMapTextEditor.Text = "documentMap1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 267);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Turtle Editor (sync)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxTurtleEditor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.documentMapTurtleEditor);
            this.splitContainer2.Size = new System.Drawing.Size(428, 261);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxTurtleEditor
            // 
            this.textBoxTurtleEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBoxTurtleEditor.AutoScrollMinSize = new System.Drawing.Size(2, 15);
            this.textBoxTurtleEditor.BackBrush = null;
            this.textBoxTurtleEditor.CharHeight = 15;
            this.textBoxTurtleEditor.CharWidth = 7;
            this.textBoxTurtleEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTurtleEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxTurtleEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTurtleEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxTurtleEditor.IsReplaceMode = false;
            this.textBoxTurtleEditor.Location = new System.Drawing.Point(0, 0);
            this.textBoxTurtleEditor.Name = "textBoxTurtleEditor";
            this.textBoxTurtleEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.textBoxTurtleEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.textBoxTurtleEditor.Size = new System.Drawing.Size(260, 261);
            this.textBoxTurtleEditor.TabIndex = 0;
            this.textBoxTurtleEditor.Zoom = 100;
            this.textBoxTurtleEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxTurtleEditor_TextChanged);
            this.textBoxTurtleEditor.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBoxTurtleEditor_TextChangedDelayed);
            // 
            // documentMapTurtleEditor
            // 
            this.documentMapTurtleEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentMapTurtleEditor.ForeColor = System.Drawing.Color.Maroon;
            this.documentMapTurtleEditor.Location = new System.Drawing.Point(0, 0);
            this.documentMapTurtleEditor.Name = "documentMapTurtleEditor";
            this.documentMapTurtleEditor.Size = new System.Drawing.Size(164, 261);
            this.documentMapTurtleEditor.TabIndex = 0;
            this.documentMapTurtleEditor.Target = this.textBoxTurtleEditor;
            this.documentMapTurtleEditor.Text = "documentMap2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridTableEditor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 267);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Table Editor (sync)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridTableEditor
            // 
            this.dataGridTableEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S,
            this.P,
            this.O});
            this.dataGridTableEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTableEditor.Location = new System.Drawing.Point(3, 3);
            this.dataGridTableEditor.Name = "dataGridTableEditor";
            this.dataGridTableEditor.RowTemplate.Height = 23;
            this.dataGridTableEditor.Size = new System.Drawing.Size(428, 261);
            this.dataGridTableEditor.TabIndex = 0;
            this.dataGridTableEditor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTableEditor_CellValueChanged);
            this.dataGridTableEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridTableEditor_KeyDown);
            // 
            // S
            // 
            this.S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.DefaultCellStyle = dataGridViewCellStyle7;
            this.S.HeaderText = "Subject";
            this.S.Name = "S";
            this.S.Width = 72;
            // 
            // P
            // 
            this.P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.DefaultCellStyle = dataGridViewCellStyle8;
            this.P.HeaderText = "Predicate";
            this.P.Name = "P";
            this.P.Width = 83;
            // 
            // O
            // 
            this.O.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.DefaultCellStyle = dataGridViewCellStyle9;
            this.O.HeaderText = "Object";
            this.O.Name = "O";
            this.O.Width = 66;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.webBrowserRelfinder);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(434, 267);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "RelFinder";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // webBrowserRelfinder
            // 
            this.webBrowserRelfinder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserRelfinder.Location = new System.Drawing.Point(3, 3);
            this.webBrowserRelfinder.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRelfinder.Name = "webBrowserRelfinder";
            this.webBrowserRelfinder.Size = new System.Drawing.Size(428, 261);
            this.webBrowserRelfinder.TabIndex = 0;
            this.webBrowserRelfinder.Url = new System.Uri("http://localhost:3030/RelFinder.swf", System.UriKind.Absolute);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(434, 267);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "SPARQL";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxQuery);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewSPARQL);
            this.splitContainer3.Size = new System.Drawing.Size(428, 261);
            this.splitContainer3.SplitterDistance = 123;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonQuery);
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 23);
            this.panel2.TabIndex = 1;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(0, 0);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 0;
            this.buttonQuery.Text = "Query";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textBoxQuery.AutoScrollMinSize = new System.Drawing.Size(263, 15);
            this.textBoxQuery.BackBrush = null;
            this.textBoxQuery.CharHeight = 15;
            this.textBoxQuery.CharWidth = 7;
            this.textBoxQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBoxQuery.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxQuery.IsReplaceMode = false;
            this.textBoxQuery.Location = new System.Drawing.Point(0, 0);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.textBoxQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.textBoxQuery.Size = new System.Drawing.Size(428, 94);
            this.textBoxQuery.TabIndex = 0;
            this.textBoxQuery.Text = "SELECT * WHERE {?s ?p ?o} LIMIT 10";
            this.textBoxQuery.Zoom = 100;
            // 
            // dataGridViewSPARQL
            // 
            this.dataGridViewSPARQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSPARQL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSPARQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSPARQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewSPARQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSPARQL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSPARQL.Name = "dataGridViewSPARQL";
            this.dataGridViewSPARQL.ReadOnly = true;
            this.dataGridViewSPARQL.RowTemplate.Height = 23;
            this.dataGridViewSPARQL.Size = new System.Drawing.Size(428, 134);
            this.dataGridViewSPARQL.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "Predicate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Object";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonChangeGraphUri);
            this.tabPage1.Controls.Add(this.textBoxGraphUri);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 267);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Preference";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonChangeGraphUri
            // 
            this.buttonChangeGraphUri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeGraphUri.Enabled = false;
            this.buttonChangeGraphUri.Location = new System.Drawing.Point(353, 16);
            this.buttonChangeGraphUri.Name = "buttonChangeGraphUri";
            this.buttonChangeGraphUri.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeGraphUri.TabIndex = 2;
            this.buttonChangeGraphUri.Text = "Update";
            this.buttonChangeGraphUri.UseVisualStyleBackColor = true;
            this.buttonChangeGraphUri.Click += new System.EventHandler(this.buttonChangeGraphUri_Click);
            // 
            // textBoxGraphUri
            // 
            this.textBoxGraphUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGraphUri.Location = new System.Drawing.Point(74, 18);
            this.textBoxGraphUri.Name = "textBoxGraphUri";
            this.textBoxGraphUri.Size = new System.Drawing.Size(272, 21);
            this.textBoxGraphUri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graph URI";
            // 
            // GraphEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.panel1);
            this.Name = "GraphEditor";
            this.Size = new System.Drawing.Size(442, 318);
            this.panel1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTextEditor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTurtleEditor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableEditor)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPARQL)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridTableEditor;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.WebBrowser webBrowserRelfinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn O;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private FastColoredTextBoxNS.FastColoredTextBox textBoxTextEditor;
        private FastColoredTextBoxNS.DocumentMap documentMapTextEditor;
        private FastColoredTextBoxNS.FastColoredTextBox textBoxTurtleEditor;
        private FastColoredTextBoxNS.DocumentMap documentMapTurtleEditor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridViewSPARQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonQuery;
        private FastColoredTextBoxNS.FastColoredTextBox textBoxQuery;
        private System.Windows.Forms.Button buttonChangeGraphUri;
        private System.Windows.Forms.TextBox textBoxGraphUri;
        private System.Windows.Forms.Label label1;



    }
}
