namespace SSWEditor
{
    partial class Preference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGraphPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFusekiPort = new System.Windows.Forms.NumericUpDown();
            this.buttonFusekiRestart = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxShowFusekiConsole = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFusekiPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graph Prefix";
            // 
            // textBoxGraphPrefix
            // 
            this.textBoxGraphPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGraphPrefix.Location = new System.Drawing.Point(120, 21);
            this.textBoxGraphPrefix.Name = "textBoxGraphPrefix";
            this.textBoxGraphPrefix.Size = new System.Drawing.Size(342, 21);
            this.textBoxGraphPrefix.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fuseki port";
            // 
            // numericUpDownFusekiPort
            // 
            this.numericUpDownFusekiPort.Location = new System.Drawing.Point(120, 62);
            this.numericUpDownFusekiPort.Name = "numericUpDownFusekiPort";
            this.numericUpDownFusekiPort.Size = new System.Drawing.Size(91, 21);
            this.numericUpDownFusekiPort.TabIndex = 2;
            // 
            // buttonFusekiRestart
            // 
            this.buttonFusekiRestart.Location = new System.Drawing.Point(217, 59);
            this.buttonFusekiRestart.Name = "buttonFusekiRestart";
            this.buttonFusekiRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonFusekiRestart.TabIndex = 3;
            this.buttonFusekiRestart.Text = "Restart";
            this.buttonFusekiRestart.UseVisualStyleBackColor = true;
            this.buttonFusekiRestart.Click += new System.EventHandler(this.buttonFusekiRestart_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(306, 98);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(387, 98);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxShowFusekiConsole
            // 
            this.checkBoxShowFusekiConsole.AutoSize = true;
            this.checkBoxShowFusekiConsole.Location = new System.Drawing.Point(298, 63);
            this.checkBoxShowFusekiConsole.Name = "checkBoxShowFusekiConsole";
            this.checkBoxShowFusekiConsole.Size = new System.Drawing.Size(148, 16);
            this.checkBoxShowFusekiConsole.TabIndex = 6;
            this.checkBoxShowFusekiConsole.Text = "Show Fuseki Console";
            this.checkBoxShowFusekiConsole.UseVisualStyleBackColor = true;
            // 
            // Preference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 139);
            this.Controls.Add(this.checkBoxShowFusekiConsole);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonFusekiRestart);
            this.Controls.Add(this.numericUpDownFusekiPort);
            this.Controls.Add(this.textBoxGraphPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Preference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preference";
            this.Load += new System.EventHandler(this.Preference_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Preference_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFusekiPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGraphPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFusekiPort;
        private System.Windows.Forms.Button buttonFusekiRestart;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxShowFusekiConsole;
    }
}