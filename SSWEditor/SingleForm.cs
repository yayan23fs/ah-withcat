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
    public partial class SingleForm : Form
    {
        public string title;
        public string label;
        public string content;

        public SingleForm()
        {
            InitializeComponent();
        }

        private void New_Load(object sender, EventArgs e)
        {
            this.Text = title;
            label1.Text = label;
            textBox1.Text = content;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            content = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewForm_KeyDown(object sender, KeyEventArgs e)
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
