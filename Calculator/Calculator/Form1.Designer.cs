namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Initialize evaluator class.
        /// </summary>
        Evaluate evaluator = new Evaluate();

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Zero = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Equals1 = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 30);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(87, 40);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 30);
            this.textBox2.TabIndex = 1;
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(87, 294);
            this.Zero.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(81, 42);
            this.Zero.TabIndex = 3;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(171, 294);
            this.Decimal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(81, 42);
            this.Decimal.TabIndex = 4;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Equals1
            // 
            this.Equals1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals1.Location = new System.Drawing.Point(254, 294);
            this.Equals1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Equals1.Name = "Equals1";
            this.Equals1.Size = new System.Drawing.Size(81, 42);
            this.Equals1.TabIndex = 5;
            this.Equals1.Text = "=";
            this.Equals1.UseVisualStyleBackColor = true;
            this.Equals1.Click += new System.EventHandler(this.Equals_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(4, 249);
            this.One.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(81, 42);
            this.One.TabIndex = 6;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(87, 249);
            this.Two.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(81, 42);
            this.Two.TabIndex = 7;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(171, 249);
            this.Three.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(81, 42);
            this.Three.TabIndex = 8;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(254, 249);
            this.Plus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(81, 42);
            this.Plus.TabIndex = 25;
            this.Plus.Text = "+";
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(4, 205);
            this.Four.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(81, 42);
            this.Four.TabIndex = 10;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(87, 205);
            this.Five.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(81, 42);
            this.Five.TabIndex = 11;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(171, 205);
            this.Six.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(81, 42);
            this.Six.TabIndex = 12;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(254, 205);
            this.Minus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(81, 42);
            this.Minus.TabIndex = 24;
            this.Minus.Text = "-";
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(4, 160);
            this.Seven.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(81, 42);
            this.Seven.TabIndex = 14;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(87, 160);
            this.Eight.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(81, 42);
            this.Eight.TabIndex = 15;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(171, 160);
            this.Nine.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(81, 42);
            this.Nine.TabIndex = 16;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(254, 160);
            this.Multiply.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(81, 42);
            this.Multiply.TabIndex = 17;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(4, 116);
            this.Clear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 42);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power.Location = new System.Drawing.Point(87, 116);
            this.Power.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(81, 42);
            this.Power.TabIndex = 19;
            this.Power.Text = "^";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrt.Location = new System.Drawing.Point(171, 116);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(81, 42);
            this.Sqrt.TabIndex = 20;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(254, 116);
            this.Divide.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(81, 42);
            this.Divide.TabIndex = 21;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sin.Location = new System.Drawing.Point(4, 71);
            this.Sin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(81, 42);
            this.Sin.TabIndex = 22;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cos.Location = new System.Drawing.Point(87, 71);
            this.Cos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(81, 42);
            this.Cos.TabIndex = 23;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(4, 294);
            this.PlusMinus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(81, 42);
            this.PlusMinus.TabIndex = 27;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 334);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Equals1);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Equals1;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button PlusMinus;
    }
}

