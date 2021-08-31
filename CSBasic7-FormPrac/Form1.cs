using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic7_FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            상태표시줄ToolStripMenuItem.Checked = !상태표시줄ToolStripMenuItem.Checked;
            statusStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;
        }
    }
}
