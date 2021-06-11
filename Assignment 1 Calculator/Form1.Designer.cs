
namespace Assignment_1_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sqrt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Square = new System.Windows.Forms.Button();
            this.PowerOf = new System.Windows.Forms.Button();
            this.Inverse = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(12, 38);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 24;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            this.Sqrt.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(93, 38);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 23);
            this.Square.TabIndex = 2;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            this.Square.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // PowerOf
            // 
            this.PowerOf.Location = new System.Drawing.Point(174, 38);
            this.PowerOf.Name = "PowerOf";
            this.PowerOf.Size = new System.Drawing.Size(75, 23);
            this.PowerOf.TabIndex = 3;
            this.PowerOf.Text = "x^y";
            this.PowerOf.UseVisualStyleBackColor = true;
            this.PowerOf.Click += new System.EventHandler(this.PowerOf_Click);
            this.PowerOf.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Inverse
            // 
            this.Inverse.Location = new System.Drawing.Point(255, 38);
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(75, 23);
            this.Inverse.TabIndex = 4;
            this.Inverse.Text = "1/x";
            this.Inverse.UseVisualStyleBackColor = true;
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            this.Inverse.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(255, 103);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 8;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            this.Divide.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(174, 67);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 7;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            this.Del.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(93, 67);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 23);
            this.C.TabIndex = 6;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            this.C.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(12, 67);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(75, 23);
            this.CE.TabIndex = 5;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            this.CE.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(255, 132);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            this.Multiply.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(174, 116);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(75, 23);
            this.Nine.TabIndex = 11;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            this.Nine.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(93, 116);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 23);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            this.eight.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 116);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 23);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            this.seven.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(255, 161);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 16;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            this.Subtract.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(174, 145);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 23);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            this.six.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(93, 145);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 23);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            this.five.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 145);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 23);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            this.four.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(255, 190);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(174, 174);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            this.three.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(93, 174);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            this.two.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 174);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            this.one.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // equation
            // 
            this.equation.Location = new System.Drawing.Point(255, 219);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(75, 23);
            this.equation.TabIndex = 0;
            this.equation.Text = "=";
            this.equation.UseVisualStyleBackColor = true;
            this.equation.Click += new System.EventHandler(this.equation_Click);
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(174, 203);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(75, 23);
            this.period.TabIndex = 23;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = true;
            this.period.Click += new System.EventHandler(this.period_Click);
            this.period.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(93, 203);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            this.zero.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(12, 203);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 23);
            this.negative.TabIndex = 21;
            this.negative.Text = "+/-";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            this.negative.Enter += new System.EventHandler(this.Button_Focus);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 266);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.period);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Inverse);
            this.Controls.Add(this.PowerOf);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sqrt);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "C# Calculator";
            this.Enter += new System.EventHandler(this.Button_Focus);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button PowerOf;
        private System.Windows.Forms.Button Inverse;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equation;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button negative;
    }
}

