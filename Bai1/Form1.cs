using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-1]))
            this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
            this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (Convert.ToInt32(txtA.Text.ToString()) + Convert.ToInt32(txtB.Text.ToString())).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (Convert.ToInt32(txtA.Text.ToString()) - Convert.ToInt32(txtB.Text.ToString())).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (Convert.ToInt32(txtA.Text.ToString()) * Convert.ToInt32(txtB.Text.ToString())).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (Convert.ToDouble(txtA.Text.ToString()) / Convert.ToDouble(txtB.Text.ToString())).ToString();
        }

        
    }
}
