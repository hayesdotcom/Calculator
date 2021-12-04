using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool enter_value = false;
        String operation = "";
        Double result = 0;
        Double result1 = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".") 
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        } 

        private void clearButton(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            labeltxt.Text = "";

        }

        private void backButton(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmetic_Button(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            labeltxt.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            labeltxt.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("This is a scientific calculator therefore STANDARD CALCULATOR is already in here. This is just for additional option HAHA. hank you!", "HUH?");
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360;
            textBox1.Width = 316;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result1 = Math.PI;
            textBox1.Text = result1.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result1 = Math.Log10(result);
            textBox1.Text = result1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Log(result);
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString(); //Note: click the number to find the sin of first.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString(); //Note: click the number to find the cos of first.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString(); //Note: click the number to find the tan of first.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Exp(result);
            textBox1.Text = result.ToString(); //Note: click the number to find the exp of first.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString(); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 3);
            textBox1.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = 1/result;
            textBox1.Text = result.ToString();
        }
    }
}
