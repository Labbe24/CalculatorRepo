﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculators
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be 0");
            }
            return dividend / divisor;
        }

        public double Accumulator
        {
            get;

            private set;
        }

        public void Clear()
        {
            Accumulator = 0.0;
        }
    }
} 
