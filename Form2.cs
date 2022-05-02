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
    public partial class Form2 : Form
    {
        bool play = true;
        bool correct = false;
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/grade6img.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Plus");
            treeView1.Nodes.Add("Minus");
            treeView1.Nodes[0].Nodes.Add("-1 + 4 = 3");
            treeView1.Nodes[0].Nodes.Add("-11 + 4 = -7");
            treeView1.Nodes[0].Nodes.Add("-31 + 61 = 30");
            treeView1.Nodes[0].Nodes.Add("-5 + 2 = -3");
            treeView1.Nodes[1].Nodes.Add("-1 - 4 = -5");
            treeView1.Nodes[1].Nodes.Add("-11 - 4 = -15");
            treeView1.Nodes[1].Nodes.Add("-31 - 61 = -92");
            treeView1.Nodes[1].Nodes.Add("-5 - 2 = -7");
            treeView1.EndUpdate();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Er\source\repos\EzMath\negativenums.wav");
            if (play) { 
                simpleSound.Play();
                play = false;
            }
            else { 
                simpleSound.Stop();
                play = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            correct = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
            correct = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(correct)
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
