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
    public partial class Form3 : Form
    {
        bool play = true;
        bool correct = false;
        public Form3()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/grade7img.JPG");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/examFunction.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Linear");
            treeView1.Nodes.Add("Quadratic");
            treeView1.Nodes[0].Nodes.Add("y = 2x + 1");
            treeView1.Nodes[0].Nodes.Add("y = x + 13");
            treeView1.Nodes[0].Nodes.Add("y = 6x + 1");
            treeView1.Nodes[0].Nodes.Add("y = 2x - 2");
            treeView1.Nodes[1].Nodes.Add("y = x^2");
            treeView1.Nodes[1].Nodes.Add("y = x^2 - 21");
            treeView1.Nodes[1].Nodes.Add("y = 5 - x^2");
            treeView1.Nodes[1].Nodes.Add("y = 2x^3 + 5");
            treeView1.EndUpdate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Er\source\repos\EzMath\functions.wav");
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correct = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            correct = false;
        }
    }
}
