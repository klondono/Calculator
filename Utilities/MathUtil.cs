using System;

namespace Utilities
{
    public class MathUtil
    {
        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double SquareRoot(double num1)
        {
            var closeEnoughValue = .0001;

            //start from zero and move our way up...
            var guess = 0;

            for(guess = 1; guess <= num1; guess++)
            {
                var answer = guess * guess;

                var diff = num1 - answer;

                if (diff <= closeEnoughValue)
                    break;
            }

            return guess;
        }
    }
}
