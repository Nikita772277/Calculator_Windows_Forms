using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button18.Enabled = false;
        }
        StringBuilder sb = new StringBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            button18.Text += "1";
            sb.Append("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button18.Text += "2";
            sb.Append("2");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button18.Text += ",";
            sb.Append(",");
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            char symbol = '+';
            string s = sb.ToString();
            foreach (char i in s)
            {
                if (i == '+' || i == '-' || i == '*' || i == '/')
                {
                    symbol = i; break;
                }
            }
            double number1 = 0, number2 = 0,answer = 0;
            string text = sb.ToString();
            string[] textArray = text.Split('+', '-', '*', '/');
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i] == "")
                {
                    continue;
                }
                else if (i == 0)
                {
                    text = textArray[0];
                    bool check = double.TryParse(text, out var number);
                    number1 = number;
                }
                else 
                {
                    text = textArray[i];
                    bool check = double.TryParse(text, out var number);
                    number2 = number;
                }
            }
            if (symbol == '+')
            {
                answer= number1+number2;
            }
            else if(symbol == '-')
            {
                answer = number1 - number2;
            }
            if (symbol == '*')
            {
                answer = number1 * number2;
            }
            if (symbol == '/')
            {
                answer = number1 / number2;
            }
            button18.Text = "";
            sb.Clear();
            //MessageBox.Show($"{answer}");
            sb.Append(answer);
            button18.Text += answer;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button18.Text += "+";
            sb.Append("+");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            button18.Text += "/";
            sb.Append("/");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button18.Text += "*";
            sb.Append("*");
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button18.Text += "-";
            sb.Append("-");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button18.Text = "";
            sb.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button18.Text += "9";
            sb.Append("9");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button18.Text += "8";
            sb.Append("8");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button18.Text += "7";
            sb.Append("7");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button18.Text += "6";
            sb.Append("6");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button18.Text += "5";
            sb.Append("5");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button18.Text += "4";
            sb.Append("4");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button18.Text += "3";
            sb.Append("3");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            button18.Text += ",";
            sb.Append(",");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button18.Text += "0";
            sb.Append("0");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
        }
    }
}
