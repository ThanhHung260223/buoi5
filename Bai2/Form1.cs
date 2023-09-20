using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            s = "Tên đăng nhập: " + txt1.Text + "\nEmail: " + txt2.Text + "\nMật khẩu:" + txt3.Text;
            MessageBox.Show(s);
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            this.errorProvider1.SetError(ctr, "You must enter Your Name");
            else
            this.errorProvider1.Clear();
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your email");
            else
                this.errorProvider1.Clear();
            string a =txt2.ToString();
            bool flag=false;
            foreach (char c in a){
                if(c=='@')
                    flag=true;
            }
            if(flag!=true){
                this.errorProvider1.SetError(ctr,"You must enter your email");
            }
            else{
                string[] b = a.Split('@');
                int s = string.Compare(b[1],"gmail.com");
                if(s!=0)
                    this.errorProvider1.SetError(ctr, "You must enter Your email");
            else
                this.errorProvider1.Clear();
            }
        }

        private void txt3_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your password");
            else
                this.errorProvider1.Clear();
        }

        private void txt4_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter again Your password");
            else
                this.errorProvider1.Clear();

            if (String.Compare(txt4.ToString(),txt3.ToString())!=0)
                this.errorProvider1.SetError(ctr, "You must enter again Your password");
            else
                this.errorProvider1.Clear();
        }
    }
}
