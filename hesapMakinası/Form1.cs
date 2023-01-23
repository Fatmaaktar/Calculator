using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinası
{
    public partial class Form1 : Form
    {

        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = true;
            panel1.Show();
            panel2.Show();
            panel2.Location = new Point(80, 115);
            panel2.Size = new Size(200, 190);

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;


            panel2.Location = new Point(20, 110);
            panel2.Size = new Size(220, 220);
            panel1.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = " ";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = " ";
            }
            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = " ";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = " ";
            }
            if (islem=="mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = " ";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button12_Click(object sender, EventArgs e)
        {

            double bolumx = Convert.ToDouble(textBox1.Text);
            bolumx = 1 / (bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }


        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(textBox1.Text);
            log = Math.Log10(log);
            textBox1.Text = Convert.ToString(log);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            tan = Math.Tan(Math.PI*tan/180);
            textBox1.Text = Convert.ToString(tan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             double cos = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            cos = Math.Cos(Math.PI*cos/180);
            textBox1.Text = Convert.ToString(cos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            sin = Math.Sin(Math.PI*sin/180);
            textBox1.Text = Convert.ToString(sin);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            x = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for(int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
                {
                    fact = fact * i;
                }
                textBox1.Text = Convert.ToString(fact);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
