using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tas_Kagit_Makas
{
    public partial class Form1 : Form
    {
        Image[] il = new Image[3];
        int ind1, ind2;
        int skorg = 0, skord = 0;
        int syc = 0;
        int gs = 3;
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label3.Text = textBox1.Text;
                label4.Text = textBox2.Text;
                label7.Visible = true;
                label8.Visible = true;
            }
            else
                MessageBox.Show("İsim Giriniz Lütfen");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            il[0]=Properties.Resources.stone;
            il[1]=Properties.Resources.scissors;
            il[2]=Properties.Resources.paper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            timer1.Enabled = true;
            gs = 3;
            label5.Text = "3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gs--;
            label5.Text = gs.ToString();
            if (gs == 0)
            {
                syc++;
                timer1.Enabled = false;
                label5.Visible = false;
                Random r = new Random();
                index = r.Next(il.Count());
                pictureBox3.Visible = true;
                pictureBox3.Image = il[index];
                ind1 = index;
                if (syc == 2)
                    timer3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            timer2.Enabled = true;
            gs = 3;
            label6.Text = "3";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            gs--;
            label6.Text = gs.ToString();
            if (gs == 0)
            {
                syc++;
                timer2.Enabled = false;
                label6.Visible = false;
                Random r = new Random();
                index = r.Next(il.Count());
                pictureBox4.Visible = true;
                pictureBox4.Image = il[index];
                ind2 = index;
                if (syc == 2)
                    timer3.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (syc == 2)
            {
                timer3.Enabled = false;
                syc = 0;
                if (ind1 == 1 && ind2 == 1)
                    MessageBox.Show("Berabare");
                else if (ind1 == 2 && ind2 == 2)
                    MessageBox.Show("Berabare");
                else if (ind1 == 0 && ind2 == 0)
                    MessageBox.Show("Berabare");
                else if (ind1 == 0 && ind2 == 2) 
                {
                    MessageBox.Show("Kazanan: " + label4.Text);
                    pictureBox1.Image = Properties.Resources.gumball_happy;
                    pictureBox2.Image = Properties.Resources.darwin_sad;
                    skorg++;
                    label8.Text = skorg.ToString();

                }
                else if (ind1 == 0 && ind2 == 1) 
                {
                    MessageBox.Show("Kazanan: " + label3.Text);
                    pictureBox2.Image = Properties.Resources.darwin_happy;
                    pictureBox1.Image = Properties.Resources.gumball_sad;
                    skord++;
                    label7.Text = skord.ToString();
                }
                else if (ind1 == 2 && ind2 == 0) 
                {
                    MessageBox.Show("Kazanan: " + label3.Text);
                    pictureBox2.Image = Properties.Resources.darwin_happy;
                    pictureBox1.Image = Properties.Resources.gumball_sad;
                    skord++;
                    label7.Text = skord.ToString();
                }
                else if (ind1 == 2 && ind2 == 1) 
                {
                    MessageBox.Show("Kazanan: " + label4.Text);
                    pictureBox1.Image = Properties.Resources.gumball_happy;
                    pictureBox2.Image = Properties.Resources.darwin_sad;
                    skorg++;
                    label8.Text = skorg.ToString();
                }
                else if (ind1 == 1 && ind2 == 0)
                {
                    MessageBox.Show("Kazanan :" + label4.Text);
                    pictureBox1.Image = Properties.Resources.gumball_happy;
                    pictureBox2.Image = Properties.Resources.darwin_sad;
                    skorg++;
                    label8.Text = skorg.ToString();
                }
                else if (ind1 == 1 && ind2 == 2) 
                {
                    MessageBox.Show("Kazann :" + label3.Text);
                    pictureBox2.Image = Properties.Resources.darwin_happy;
                    pictureBox1.Image = Properties.Resources.gumball_sad;
                    skord++;
                    label7.Text = skord.ToString();
                }
            }
        }
    }
}
