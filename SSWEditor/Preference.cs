using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSWEditor
{
    public partial class Preference : Form
    {
        public Preference()
        {
            InitializeComponent();
        }

        private void Preference_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxGraphPrefix.Text = MainForm.config.GlobalPrefix;
                numericUpDownFusekiPort.Minimum = 1;
                numericUpDownFusekiPort.Maximum = 65535;
                numericUpDownFusekiPort.Value = MainForm.config.FusekiPort;
                checkBoxShowFusekiConsole.Checked = MainForm.config.ShowFusekiConsole;

                var cvt = new FontConverter();
                fontDialog1.Font = MainForm.config.GetEditorFont();
                textBoxFont.Text = fontDialog1.Font.Name;
                textBoxFont.Font = fontDialog1.Font;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error during load font config. " + ex);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MainForm.config.GlobalPrefix = textBoxGraphPrefix.Text;
            MainForm.config.FusekiPort = (int)numericUpDownFusekiPort.Value;
            MainForm.config.ShowFusekiConsole = checkBoxShowFusekiConsole.Checked;
            MainForm.config.SetEditorFont(fontDialog1.Font);

            MainForm.SaveConfig();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Preference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click(null, null);
            }

        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFont.Text = fontDialog1.Font.Name;
                textBoxFont.Font = fontDialog1.Font;
            }
        }

        private void buttonFusekiRestart_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fuseki.Start(checkBoxShowFusekiConsole.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            if (!checkBoxShowFusekiConsole.Checked)
            {
                MessageBox.Show("restarted");
            }
        }
    }
}
