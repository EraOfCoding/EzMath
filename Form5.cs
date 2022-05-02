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
    public partial class Form5 : Form
    {
        bool play = true;
        bool correct = false;
        public Form5()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/grade9img.JPG");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/trigExam.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("a / sinA = b / sinB = c/sinC");
            treeView1.Nodes.Add("a^2 = b^2 + c^2 - 2bc * cosA");
            treeView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Er\source\repos\EzMath\trygonometry.wav");
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correct = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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
