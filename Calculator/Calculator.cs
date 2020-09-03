using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            Calculator cal = new Calculator();

            Console.WriteLine("{0}",cal.Power(2, 3));
            Console.WriteLine("{0}", cal.Power(-2, 3));
            Console.WriteLine("{0}", cal.Power(2, -3));
            Console.WriteLine("{0}", cal.Power(-2, -3));
        }
        public double Add(double a, double b)
        {
            return a+b;
        }

        public double Subtract(double a, double b)
        {
            return a-b;
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}
