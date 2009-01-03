using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Compute
    {
        private double add(double num1, double num2)
        {
            return num1 + num2;
        }

        private double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private double divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                // Insert error message
                return -1;
            }
            return num1 / num2;
        }

        private double power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        private double sqrt(double num1)
        {
            if (num1 < 0)
            {
                // Insert error message
                return -1;
            }
            return Math.Sqrt(num1);
        }

        private double sin(double degree)
        {
            return Math.Sin(degree);
        }

        private double cos(double degree)
        {
            return Math.Cos(degree);
        }
    }
}
