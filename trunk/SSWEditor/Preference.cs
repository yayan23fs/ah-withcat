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
            textBoxGraphPrefix.Text = MainForm.config.GlobalPrefix;
            numericUpDownFusekiPort.Minimum = 1;
            numericUpDownFusekiPort.Maximum = 65535;
            numericUpDownFusekiPort.Value = MainForm.config.FusekiPort;
            checkBoxShowFusekiConsole.Checked = MainForm.config.ShowFusekiConsole;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MainForm.config.GlobalPrefix = textBoxGraphPrefix.Text;
            MainForm.config.FusekiPort = (int)numericUpDownFusekiPort.Value;
            MainForm.config.ShowFusekiConsole = checkBoxShowFusekiConsole.Checked;
            MainForm.SaveConfig();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonFusekiRestart_Click(object sender, EventArgs e)
        {
            try
            {
                Fuseki.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            if (MainForm.config.ShowFusekiConsole == false)
            {
                MessageBox.Show("restarted");
            }
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
    }
}
