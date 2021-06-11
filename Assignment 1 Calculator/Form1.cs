//C# Windows Form Calculator - Assignment 1
//Written by: Andrew Pederson
//Date: 5/30/2021
//Author's Comments: Look, I know the force focus for the enter button becoming = is messy.
//But it's been four hours of trying to figure that thing out, and if I load one more stackoverflow
//Page that says "Just put it in the KeyDown/KeyPress Event" I'm gonna throw my computer out of my window
//And then myself.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Calculator
{
    public partial class Calculator : Form
    {
        //Variable Declarations and Initialization
        string value = string.Empty;
        string firstNum = string.Empty;
        string secondNum = string.Empty;
        char operation;
        double answer = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        //Button Click Events - Does what you expect: shows the number, adds it to the value
        //Operation buttons (+-*/etc.) set the value to firstNum then clears up to accept the second number
        //Equals does what you think as well. It's pretty straightforward.
        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "0";
            this.textBox1.Text += value;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "1";
            this.textBox1.Text += value;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "2";
            this.textBox1.Text += value;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "3";
            this.textBox1.Text += value;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "4";
            this.textBox1.Text += value;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "5";
            this.textBox1.Text += value;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "6";
            this.textBox1.Text += value;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "7";
            this.textBox1.Text += value;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "8";
            this.textBox1.Text += value;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            value += "9";
            this.textBox1.Text += value;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                textBox1.Text = "-" + textBox1.Text;
                this.value = textBox1.Text;
            }
        }

        private void period_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                if(textBox1.Text == string.Empty)
                {
                    textBox1.Text = "0.";
                }
                else
                {
                    value += ".";
                }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = '+';
            value = string.Empty;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = '-';
            value = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = '*';
            value = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = '/';
            value = string.Empty;
        }

        private void equation_Click(object sender, EventArgs e)
        {
            secondNum = value;
            double num1, num2;
            double.TryParse(firstNum, out num1);
            double.TryParse(secondNum, out num2);

            if (operation == '+')
            {
                answer = num1 + num2;
                textBox1.Text = answer.ToString();
                value = answer.ToString();
            }

            else if (operation == '-')
            {
                answer = num1 - num2;
                textBox1.Text = answer.ToString();
                value = answer.ToString();
            }

            else if (operation == '*')
            {
                answer = num1 * num2;
                textBox1.Text = answer.ToString();
                value = answer.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    answer = num1 / num2;
                    textBox1.Text = answer.ToString();
                    value = answer.ToString();
                }
                else
                {
                    textBox1.Text = "Error: Divide by Zero";
                }
            }

            else if (operation == 'i')
            {
                num2 = 1 / num2;
                answer = Math.Pow(num1, num2);
                textBox1.Text = answer.ToString();
                value = answer.ToString();
            }

            else if (operation == 'p')
            {
                answer = Math.Pow(num1, num2);
                textBox1.Text = answer.ToString();
                value = answer.ToString();
            }
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = 'i';
            value = string.Empty;
        }

        private void PowerOf_Click(object sender, EventArgs e)
        {
            firstNum = value;
            operation = 'p';
            value = string.Empty;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            firstNum = value;
            double numSq;
            double.TryParse(firstNum, out numSq);

            answer = numSq * numSq;
            textBox1.Text = answer.ToString();
            value = answer.ToString();
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            firstNum = value;
            double numRt;
            double.TryParse(firstNum, out numRt);

            answer = Math.Sqrt(numRt);
            textBox1.Text = answer.ToString();
            value = answer.ToString();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            this.value = string.Empty;
            this.firstNum = string.Empty;
            this.secondNum = string.Empty;
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            this.value = string.Empty;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
                this.value = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                this.value = textBox1.Text;
            }
        }

        //It's a mess. Don't look at it. It's not real.
        public void Button_Focus(object sender, EventArgs e)
        {
            equation.Focus();
        }
        //How do you explain "Enter Button PTSD" to a therapist?

        //KeyDown events - allows for numerical keypad shenanigans
        //Don't gotta validate your entries when your entries can only be valid ones
        //Modern problems require modern solutions
        //Principle of Least Privilege: Give the user an inch, and they'll crash the program in ways
        //You'll never even imagine.
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || (e.KeyCode.Equals(Keys.Return)))
            {
                equation.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad0) || e.KeyCode.Equals(Keys.D0))
            {
                zero.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad1) || e.KeyCode.Equals(Keys.D1))
            {
                one.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad2) || e.KeyCode.Equals(Keys.D2))
            {
                two.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad3) || e.KeyCode.Equals(Keys.D3))
            {
                three.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad4) || e.KeyCode.Equals(Keys.D4))
            {
                four.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad5) || e.KeyCode.Equals(Keys.D5))
            {
                five.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad6) || e.KeyCode.Equals(Keys.D6))
            {
                six.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad7) || e.KeyCode.Equals(Keys.D7))
            {
                seven.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad8) || e.KeyCode.Equals(Keys.D8))
            {
                eight.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.NumPad9) || e.KeyCode.Equals(Keys.D9))
            {
                Nine.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Add))
            {
                Add.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Decimal))
            {
                period.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Subtract))
            {
                Subtract.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Multiply))
            {
                Multiply.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Divide))
            {
                Divide.PerformClick();
            }

            if (e.KeyCode.Equals(Keys.Back))
            {
                Del.PerformClick();
            }
        }
    }
}
