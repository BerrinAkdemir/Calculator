using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesiÇalışması
{
    public partial class Form1 : Form
    {
        private double Number1;
        private double Number2;
        private string Operation = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text += "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "+";
            label1.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "-";
            label1.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "*";
            label1.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "/";
            label1.Text = "";

        }
        //comma 
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ",";
        }
        //turn the negative into a positive, the positive into a negative
        private void button19_Click(object sender, EventArgs e)
        {
            double PN = Convert.ToDouble(label1.Text);
            label1.Text = Convert.ToString(-1 * PN);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            string f, s;
            f = Convert.ToString(Number1);
            s = Convert.ToString(Number2);

            f = "";
            s = "";


        }
        //Backspace
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
            if (label1.Text == "")
            {

                label1.Text = "0";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Number2 = double.Parse(label1.Text);
            switch (Operation)
            {
                case "+":
                    label1.Text = (Number1 + Number2).ToString();
                    break;

                case "-":
                    label1.Text = (Number1 - Number2).ToString();
                    break;

                case "*":
                    label1.Text = (Number1 * Number2).ToString();
                    break;

                case "/":
                    label1.Text = (Number1 / Number2).ToString();
                    break;


                case "%":
                    label1.Text = (Number1 % Number2).ToString();
                    break;

                case "^":
                    label1.Text = Math.Pow(Number1, Number2).ToString();
                    break;


                default:
                    break;
            }


        }
        //mod
        private void button20_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "%";
            label1.Text = "";
        }

        //	factorial 
        private void button18_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(label1.Text);
            double factorial = 1;
            for (int i = 1; i <= Number1; i++)
            {
                factorial = factorial * i;
            }

            label1.Text = factorial.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //To find the reciprocal 
            if (label1.Text != string.Empty)
            {

                double chk = Convert.ToDouble("1") / Convert.ToDouble(label1.Text);
                label1.Text = chk.ToString();
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Number1 = double.Parse(label1.Text);
            Operation = "^";
            label1.Text = "";
        }
    }
}
