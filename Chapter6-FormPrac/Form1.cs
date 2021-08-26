using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMeaageBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;

            if (sender == btnMeaageBox1)
            {
                result = MessageBox.Show("안녕하세요?");
            }
            else if(sender == btnMeaageBox2)
            {
                result = MessageBox.Show("안녕하세요?", "환영인사");
            }
            else if(sender == btnMeaageBox3)
            {
                result = MessageBox.Show("안녕하세요?", "환영인사");
            }

            switch (result)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    MessageBox.Show("좋은 하루~!", "시스템");
                    break;
                case DialogResult.No:
                    MessageBox.Show("가서 쉬세용!", "바잉");
                    break;

            }
        }

        private void btnModaless1_Click(object sender, EventArgs e)
        {
            Form form = new FormCustom();
            IsMdiContainer = true;

            if(sender == btnModaless1)
            {
                form.MdiParent = this;
                form.Show();
            }
            else if(sender == btnModal)
            {
                form.ShowDialog();
            }
        }
    }
}
