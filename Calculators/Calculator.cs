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
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
           Accumulator = a - b;
           return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            if (exp < 0)
            {
                throw new ArgumentException("Exponent cannot be negative");
            }
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be 0");
            }
            Accumulator = dividend / divisor;
            return Accumulator;
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

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be 0");
            }
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Exponent cannot be negative");
            }
            Accumulator = Math.Pow(Accumulator, a);
            return Accumulator;
        }

    }
} 
