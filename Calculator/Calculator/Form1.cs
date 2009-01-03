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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('0');
            this.textBox1.Text += '0';
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('.');
            this.textBox1.Text += '.';
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            //TODO: add an event handler to create a string from the stack, make an evaluation tree and pass to output
            //convert stack to string
            //expression tree made with string
            StringBuilder expressionstring = new StringBuilder();
            
            while (this.evaluator.myStack.Count() != 0)
            {
                expressionstring.Insert(0, this.evaluator.myStack.Pop());
            }

            ExpressionTree tree = new ExpressionTree(expressionstring.ToString());
            //this.evaluator.evaluate();
            this.textBox2.Text = tree.Evaluate().ToString();
            
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('1');
            this.textBox1.Text += '1';
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('2');
            this.textBox1.Text += '2';
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('3');
            this.textBox1.Text += '3';
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('+');
            this.textBox1.Text += '+';
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('4');
            this.textBox1.Text += '4';
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('5');
            this.textBox1.Text += '5';
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('6');
            this.textBox1.Text += '6';
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('-');
            this.textBox1.Text += '-';
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('7');
            this.textBox1.Text += '7';
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('8');
            this.textBox1.Text += '8';
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('9');
            this.textBox1.Text += '9';
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('*');
            this.textBox1.Text += '*';
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Clear();
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void Power_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('^');
            this.textBox1.Text += '^';
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('√');
            this.textBox1.Text += '√';
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('/');
            this.textBox1.Text += '/';
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('S');
            this.evaluator.myStack.Push('i');
            this.evaluator.myStack.Push('n');
            this.textBox1.Text += 'S';
            this.textBox1.Text += 'i';
            this.textBox1.Text += 'n';
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            this.evaluator.myStack.Push('C');
            this.evaluator.myStack.Push('o');
            this.evaluator.myStack.Push('s');
            this.textBox1.Text += 'C';
            this.textBox1.Text += 'o';
            this.textBox1.Text += 's';
        }
    }
}
