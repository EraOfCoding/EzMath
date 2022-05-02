using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzMath
{
    public partial class Form1 : Form
    {
        bool pname = false;
        bool pgrade = false;
        bool ptopic = false;
        string grade = "9";
        string topic = "";
        bool checkbox = false;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:/Users/Er/source/repos/EzMath/homeIcon.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            comboBox1.Items.AddRange(new object[] {
                        "6",
                        "7",
                        "8",
                        "9"});
            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 9;
            progressBar1.Step = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ptopic)
            {
                for (int i = 0; i < 3; i++)
                {
                    progressBar1.PerformStep();
                }
            }
            ptopic = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade = comboBox1.SelectedItem.ToString();
            if(grade == "6")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] {"Negative numbers",
                            });
            }
            else if (grade == "7")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] {
                    "Introduction to functions",
                            });
            }
            else if (grade == "8")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] {"Pythagorean theorem",
                            });
            }
            else if (grade == "9")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] {
                            "Introduction to trygonometry",
                            });
            }
            if (!pgrade)
            {
                for (int i = 0; i < 3; i++)
                {
                    progressBar1.PerformStep();
                }
            }
            pgrade = true;
            topic = comboBox2.Text;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!pname)
            {
                for (int i = 0; i < 3; i++)
                {
                    progressBar1.PerformStep();
                }
            }
            pname = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkbox)
            {
                if(grade == "6")
                {
                    Form2 frm2 = new Form2();
                    this.Hide();
                    frm2.Show();
                }
                else if (grade == "7")
                {
                    Form3 frm3 = new Form3();
                    this.Hide();
                    frm3.Show();
                }
                else if (grade == "8")
                {
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.Show();
                }
                else
                {
                    Form5 frm5 = new Form5();
                    this.Hide();
                    frm5.Show();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkbox = Convert.ToBoolean(checkBox1.CheckState);
        }
    }
}
