using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible = false;
            pictureBox1.Visible = true;
            txtSi.Visible = false;
            lbl1.Visible = true;
            button1.Visible = true;
            ////Form1 form = new Form1();
            //Form1.Size = new Size(250, 200);
            //Form1.Show();
            Size = new Size(550, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
            label4.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            lbl1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            Size = new Size(816, 489);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            label1.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button5.Visible = true;
            label4.Visible = true;
            pictureBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            Size = new Size(816, 200);
        }
    }
}
