using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
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

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-1]))
            this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
            this.errorProvider1.Clear();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a=Convert.ToInt32(txtA.Text);
            b=Convert.ToInt32(txtB.Text);
            txtUCLN.Text=UCLN(a,b).ToString();
            txtBCNN.Text=BCNN(a,b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.ResetText();
            txtB.ResetText();
            txtUCLN.ResetText();
            txtBCNN.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
