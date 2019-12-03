using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double oneNum, twoNum;
        string Operator = "";
        bool isNewNum = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (Operator != "" && !isNewNum)
            {
                twoNum = double.Parse(textBox1.Text);
                Pro();
            }
            Button b = sender as Button;
            Operator = b.Text;
            isNewNum = true;
            oneNum = double.Parse(textBox1.Text);
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (isNewNum)
            {
                textBox1.Text = b.Text;
                isNewNum = false;
            }
            else
            {
                textBox1.Text += b.Text;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (Operator != "")
            {
                if (!isNewNum)
                    twoNum = double.Parse(textBox1.Text);
                Pro();
            }
            isNewNum = true;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            oneNum = 0;
            twoNum = 0;
            Operator = "";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().IndexOf(".") == -1)
            {
                textBox1.Text += ".";
            }
        }

        private void Pro()
        {
            switch (Operator)
            {
                case "+":
                    oneNum += twoNum;
                    break;
                case "-":
                    oneNum -= twoNum;
                    break;
                case "*":
                    oneNum *= twoNum;
                    break;
                case "/":
                    oneNum /= twoNum;
                    break;
            }
            textBox1.Text = oneNum.ToString();
        }
    }
}
