﻿namespace SSWEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPageTextEditor = new System.Windows.Forms.TabPage();
            this.textBoxTextEditor = new SSWEditor.IndentTextBox();
            this.tabPageRelFinder = new System.Windows.Forms.TabPage();
            this.webBrowserRelfinder = new System.Windows.Forms.WebBrowser();
            this.tabPagePreference = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTurtleEditor = new System.Windows.Forms.TabPage();
            this.textBoxTurtleEditor = new SSWEditor.IndentTextBox();
            this.tabPageTableEditor = new System.Windows.Forms.TabPage();
            this.dataGridTableEditor = new System.Windows.Forms.DataGridView();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSPARQL = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBoxQuery = new SSWEditor.IndentTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.dataGridViewSPARQL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.textBoxGraphUri = new System.Windows.Forms.TextBox();
            this.buttonChangeGraphUri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPageTextEditor.SuspendLayout();
            this.tabPageRelFinder.SuspendLayout();
            this.tabPagePreference.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTurtleEditor.SuspendLayout();
            this.tabPageTableEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableEditor)).BeginInit();
            this.tabPageSPARQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPARQL)).BeginInit();
            this.tabPageGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMsg);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 25);
            this.panel1.TabIndex = 3;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMsg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMsg.ForeColor = System.Drawing.Color.Red;
            this.textBoxMsg.Location = new System.Drawing.Point(0, 0);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMsg.Size = new System.Drawing.Size(438, 25);
            this.textBoxMsg.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(444, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPageTextEditor);
            this.tabControl3.Controls.Add(this.tabPageRelFinder);
            this.tabControl3.Controls.Add(this.tabPagePreference);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 25);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(519, 293);
            this.tabControl3.TabIndex = 4;
            this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabControl3_SelectedIndexChanged);
            // 
            // tabPageTextEditor
            // 
            this.tabPageTextEditor.Controls.Add(this.textBoxTextEditor);
            this.tabPageTextEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextEditor.Name = "tabPageTextEditor";
            this.tabPageTextEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextEditor.Size = new System.Drawing.Size(511, 267);
            this.tabPageTextEditor.TabIndex = 1;
            this.tabPageTextEditor.Text = "Text Editor";
            this.tabPageTextEditor.UseVisualStyleBackColor = true;
            // 
            // textBoxTextEditor
            // 
            this.textBoxTextEditor.AcceptsTab = true;
            this.textBoxTextEditor.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTextEditor.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTextEditor.Location = new System.Drawing.Point(3, 3);
            this.textBoxTextEditor.Name = "textBoxTextEditor";
            this.textBoxTextEditor.Size = new System.Drawing.Size(505, 261);
            this.textBoxTextEditor.TabIndex = 1;
            this.textBoxTextEditor.Text = "";
            this.textBoxTextEditor.WordWrap = false;
            this.textBoxTextEditor.TextChanged += new System.EventHandler(this.textBoxTextEditor_TextChanged);
            // 
            // tabPageRelFinder
            // 
            this.tabPageRelFinder.Controls.Add(this.webBrowserRelfinder);
            this.tabPageRelFinder.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelFinder.Name = "tabPageRelFinder";
            this.tabPageRelFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelFinder.Size = new System.Drawing.Size(511, 267);
            this.tabPageRelFinder.TabIndex = 2;
            this.tabPageRelFinder.Text = "RelFinder";
            this.tabPageRelFinder.UseVisualStyleBackColor = true;
            // 
            // webBrowserRelfinder
            // 
            this.webBrowserRelfinder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserRelfinder.Location = new System.Drawing.Point(3, 3);
            this.webBrowserRelfinder.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRelfinder.Name = "webBrowserRelfinder";
            this.webBrowserRelfinder.Size = new System.Drawing.Size(505, 261);
            this.webBrowserRelfinder.TabIndex = 0;
            this.webBrowserRelfinder.Url = new System.Uri("http://localhost:3030/RelFinder.swf", System.UriKind.Absolute);
            // 
            // tabPagePreference
            // 
            this.tabPagePreference.Controls.Add(this.tabControl1);
            this.tabPagePreference.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreference.Name = "tabPagePreference";
            this.tabPagePreference.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreference.Size = new System.Drawing.Size(511, 267);
            this.tabPagePreference.TabIndex = 6;
            this.tabPagePreference.Text = "Preference";
            this.tabPagePreference.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGraph);
            this.tabControl1.Controls.Add(this.tabPageTurtleEditor);
            this.tabControl1.Controls.Add(this.tabPageTableEditor);
            this.tabControl1.Controls.Add(this.tabPageSPARQL);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 261);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageTurtleEditor
            // 
            this.tabPageTurtleEditor.Controls.Add(this.textBoxTurtleEditor);
            this.tabPageTurtleEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageTurtleEditor.Name = "tabPageTurtleEditor";
            this.tabPageTurtleEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTurtleEditor.Size = new System.Drawing.Size(497, 235);
            this.tabPageTurtleEditor.TabIndex = 4;
            this.tabPageTurtleEditor.Text = "Turtle Editor (sync)";
            this.tabPageTurtleEditor.UseVisualStyleBackColor = true;
            // 
            // textBoxTurtleEditor
            // 
            this.textBoxTurtleEditor.AcceptsTab = true;
            this.textBoxTurtleEditor.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTurtleEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTurtleEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTurtleEditor.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTurtleEditor.Location = new System.Drawing.Point(3, 3);
            this.textBoxTurtleEditor.Name = "textBoxTurtleEditor";
            this.textBoxTurtleEditor.Size = new System.Drawing.Size(491, 229);
            this.textBoxTurtleEditor.TabIndex = 2;
            this.textBoxTurtleEditor.Text = "";
            this.textBoxTurtleEditor.WordWrap = false;
            this.textBoxTurtleEditor.TextChanged += new System.EventHandler(this.textBoxTurtleEditor_TextChanged);
            // 
            // tabPageTableEditor
            // 
            this.tabPageTableEditor.Controls.Add(this.dataGridTableEditor);
            this.tabPageTableEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageTableEditor.Name = "tabPageTableEditor";
            this.tabPageTableEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTableEditor.Size = new System.Drawing.Size(497, 235);
            this.tabPageTableEditor.TabIndex = 0;
            this.tabPageTableEditor.Text = "Table Editor (sync)";
            this.tabPageTableEditor.UseVisualStyleBackColor = true;
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
            this.dataGridTableEditor.Size = new System.Drawing.Size(491, 229);
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
            // tabPageSPARQL
            // 
            this.tabPageSPARQL.Controls.Add(this.splitContainer3);
            this.tabPageSPARQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSPARQL.Name = "tabPageSPARQL";
            this.tabPageSPARQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSPARQL.Size = new System.Drawing.Size(497, 235);
            this.tabPageSPARQL.TabIndex = 5;
            this.tabPageSPARQL.Text = "SPARQL";
            this.tabPageSPARQL.UseVisualStyleBackColor = true;
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
            this.splitContainer3.Panel1.Controls.Add(this.textBoxQuery);
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewSPARQL);
            this.splitContainer3.Size = new System.Drawing.Size(491, 229);
            this.splitContainer3.SplitterDistance = 107;
            this.splitContainer3.TabIndex = 0;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.AcceptsTab = true;
            this.textBoxQuery.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuery.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxQuery.Location = new System.Drawing.Point(0, 0);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(491, 84);
            this.textBoxQuery.TabIndex = 2;
            this.textBoxQuery.Text = "SELECT * WHERE {?s ?p ?o} LIMIT 10";
            this.textBoxQuery.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 23);
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
            this.dataGridViewSPARQL.Size = new System.Drawing.Size(491, 118);
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
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.textBoxGraphUri);
            this.tabPageGraph.Controls.Add(this.buttonChangeGraphUri);
            this.tabPageGraph.Controls.Add(this.label1);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(497, 235);
            this.tabPageGraph.TabIndex = 0;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // textBoxGraphUri
            // 
            this.textBoxGraphUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGraphUri.Location = new System.Drawing.Point(73, 25);
            this.textBoxGraphUri.Name = "textBoxGraphUri";
            this.textBoxGraphUri.Size = new System.Drawing.Size(373, 21);
            this.textBoxGraphUri.TabIndex = 1;
            // 
            // buttonChangeGraphUri
            // 
            this.buttonChangeGraphUri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeGraphUri.Enabled = false;
            this.buttonChangeGraphUri.Location = new System.Drawing.Point(453, 23);
            this.buttonChangeGraphUri.Name = "buttonChangeGraphUri";
            this.buttonChangeGraphUri.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeGraphUri.TabIndex = 2;
            this.buttonChangeGraphUri.Text = "Update";
            this.buttonChangeGraphUri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
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
            this.Size = new System.Drawing.Size(519, 318);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPageTextEditor.ResumeLayout(false);
            this.tabPageRelFinder.ResumeLayout(false);
            this.tabPagePreference.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTurtleEditor.ResumeLayout(false);
            this.tabPageTableEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableEditor)).EndInit();
            this.tabPageSPARQL.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSPARQL)).EndInit();
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageGraph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPageTableEditor;
        private System.Windows.Forms.DataGridView dataGridTableEditor;
        private System.Windows.Forms.TabPage tabPageTextEditor;
        private System.Windows.Forms.TabPage tabPageRelFinder;
        private System.Windows.Forms.WebBrowser webBrowserRelfinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn O;
        private System.Windows.Forms.TabPage tabPageTurtleEditor;
        private System.Windows.Forms.TabPage tabPageSPARQL;
        private System.Windows.Forms.TabPage tabPagePreference;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridViewSPARQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonChangeGraphUri;
        private System.Windows.Forms.TextBox textBoxGraphUri;
        private System.Windows.Forms.Label label1;
        private IndentTextBox textBoxTextEditor;
        private IndentTextBox textBoxTurtleEditor;
        private IndentTextBox textBoxQuery;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGraph;



    }
}