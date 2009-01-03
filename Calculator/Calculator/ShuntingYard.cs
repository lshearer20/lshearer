using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.ComponentModel;

namespace Calculator
{
    public class ExpressionTree
    {
        private Node root;
        public static Dictionary<string, double> variables = new Dictionary<string, double>(); //holds all of the variable and stuff
        public static Dictionary<string, int> precedence = new Dictionary<string, int> { { "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }, { "(", -1 }, { "√", 2 } };
        char[] operations = { '+', '-', '*', '/', '√' }; //this is easier isn't it
        private string expression;
        private string Expression //just setters and getters
        {
            get
            {
                return expression;
            }
            set
            {
                expression = value;
            }
        }
        public bool selfref;
        //Implement this constructor to construct the tree from the specific expression
        public ExpressionTree(string expression)
        {
            variables = new Dictionary<string, double>(); //each expression should get its own dictionary for variables
            this.expression = expression;
            if (expression.Contains('√'))
            {
                Stack<string> mystack;
                string search = "";
                while (search != "√")
                {
                    
                }
            }
            List<string> postFix = ShuntingYardAlgorithm(expression);
            Stack<Node> TreeStack = new Stack<Node> { };
            OperationNode temp;
            //we have the postfix now we need to turn it into a tree

            foreach (string x in postFix)
            {
                if (precedence.ContainsKey(x)) //operator, pointers to top two trees are popped and a new root(the operator) left T2 and right T1. This trees pointer is pushed on the stack
                {
                    temp = (OperationNode)NodeFactory(x);
                    temp.right = TreeStack.Pop();
                    if (TreeStack.Count > 0)
                    {
                        temp.left = TreeStack.Pop();
                    }
                    TreeStack.Push(temp);
                }
                else //if symbol is an operand, a one-node tree is created and its pointer is pushed onto a stack
                {
                    TreeStack.Push(NodeFactory(x));
                }
            }

            //what if it's just 1...


            root = TreeStack.Pop();
            //make the tree


        }
        public List<string> ShuntingYardAlgorithm(string expression)
        {
            List<string> exp = new List<string>();
            List<string> result = new List<string>();
            //we need a queue and a stack!
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            string temp;
            //how did we parse this thing before? basically by the operators, if there's an operator we parse?
            exp = parse(expression);
            //parse works so now we have a parsed expression that we can trust!
            foreach (string x in exp)
            {

                //we decide what to do with it
                if (x == "(")
                {
                    stack.Push(x);
                }
                else if (x == ")")
                {
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Pop();
                }
                else if (precedence.ContainsKey(x)) //an operator
                {

                    //TODO: this breaks on 1+1+1 for some reason...
                    while (stack.Count != 0 && precedence[stack.Peek()] >= precedence[x] && stack.Peek() != "(")
                    {
                        temp = stack.Pop();
                        queue.Enqueue(temp);
                    }

                    stack.Push(x);
                }
                else
                {
                    //we have a number we know we want to put it into the queue!
                    //what about vars?
                    queue.Enqueue(x);
                }

            }
            if (stack.Count != 0)
            {
                while (stack.Count != 0)
                {
                    queue.Enqueue(stack.Pop());
                }
            }

            while (queue.Count != 0)
            {
                result.Add(queue.Dequeue());
            }

            return result;
        }
        public List<string> parse(string expr)
        {
            //it seems like we should check our cells here to make sure all of our references are good?
            List<string> result = new List<string>();
            StringBuilder builder = new StringBuilder();
            //some logic            
            for (int i = 0; i < expr.Length; i++)
            {
                //how do we break this up
                if (expr[i] != ' ')
                {
                    if (Char.IsDigit(expr, i))
                    {
                        builder.Append(expr[i]);
                        if (i == (expr.Length - 1))
                        {
                            result.Add(builder.ToString());
                            builder.Clear();
                        }
                    }
                    else if (precedence.ContainsKey(expr[i].ToString()) == false && expr[i] != '(' && expr[i] != ')') //not a number, not an op, must be a var. will be in the same positions we might expect a number
                    {
                        builder.Append(expr[i]);
                        if (i == expr.Length - 1)
                        {
                            result.Add(builder.ToString());
                            builder.Clear();
                        }
                    }
                    else
                    {
                        if (builder != null && builder.Length != 0)
                        {
                            result.Add(builder.ToString());
                            builder.Clear();
                        }
                        result.Add(expr[i].ToString());
                    }
                }
            }
            if (builder.Length != 0) //if there is a space as the last character....
            {
                result.Add(builder.ToString());
            }
            return result;
        }
        Node NodeFactory(string x) //we talked about this in class
        {
            if (precedence.ContainsKey(x))
            {
                return new OperationNode(x[0]);
            }
            else if (Double.TryParse(x, out double val))
            {
                return new ValueNode(val);
            }
            else
            {
                return new VariableNode(x);
            }
        }
        public void SetVariable(string var, double value)
        {
            try
            {
                variables.Add(var, value);
            }
            catch
            {
                variables[var] = value;
            }
        }
        //Implement this method with no parameters that evaluates the expression to a double value
        public double Evaluate()
        {
            if (root != null)
            {
                return root.Eval(); //this will evaluate starting at the root
            }
            else
            {
                return -0.01;
            }
        }
        private class VariableNode : Node
        {
            private readonly string var;

            public VariableNode(string name)
            {
                this.var = name;

            }

            public override double Eval()
            {
                if (variables.ContainsKey(var))
                {
                    return variables[var];
                }
                else
                {
                    return 0;
                }
            }
        }
        private class OperationNode : Node
        {
            public Node left, right;
            char operation;

            public OperationNode(char oper)
            {
                operation = oper;
                left = right = null;
            }
            public override double Eval()
            {
                switch (operation)
                {
                    case '+':
                        return this.left.Eval() + this.right.Eval();
                    case '-':
                        return this.left.Eval() - this.right.Eval();
                    case '*':
                        return this.left.Eval() * this.right.Eval();
                    case '/':
                        return this.left.Eval() / this.right.Eval();
                    //case '√':
                    //    return Math.Sqrt(this.right.Eval());
                }
                return 0.0;
            }
        }
        private class ValueNode : Node
        {
            double value;
            public ValueNode(double value)
            {
                this.value = value;
            }
            public override double Eval()
            {
                return value;
            }
        }
    }
}
public abstract class Node
{
    public abstract double Eval();
}