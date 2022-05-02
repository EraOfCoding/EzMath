using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EzMath
{
    public partial class Form4 : Form
    {
        bool play = true;
        bool correct = false;
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/grade8img.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/pythagoreanExam.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("5^2 = 3^2 + 4^2");
            treeView1.Nodes.Add("13 = 2^2 + 3^2");
            treeView1.EndUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Er\source\repos\EzMath\pythagorean.wav");
            if (play)
            {
                simpleSound.Play();
                play = false;
            }
            else
            {
                simpleSound.Stop();
                play = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            correct = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (correct)
            {
                label9.Text = "Correct! You did well!";
            }
            else
            {
                label9.Text = "You made a mistake! Learn and try again!";
            }
        }
    }
}
