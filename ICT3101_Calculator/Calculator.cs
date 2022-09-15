using System;
using System.Collections.Generic;
using System.Text;

/*ICT3101: Lab 1
Prepared by: Daniel Tan
*/

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "aot":
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "aoc":
                    result = AreaOfCircle(num1);
                    break;
                case "ufa":
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "ufb":
                    result = UnknownFunctionB(num1, num2);
                    break;
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            //return (num1 + num2);
            string bin1 = num1.ToString();
            bin1 = bin1 + "00";

            string bin2 = num2.ToString();

            double finalNum1 = Convert.ToDouble(Convert.ToInt32(bin1, 2));
            double finalNum2 = Convert.ToDouble(Convert.ToInt32(bin2, 2));
            return (finalNum1 + finalNum2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //if (num1 == 0 || num2 == 0)
            //{
            //    throw new ArgumentException();
            //}
            //return (num1 / num2);
            double result;
            if (num1 == 0 && num2 == 0)
            {
                result = 1;
            }
            else
            {
                result = (num1 / num2);
            }
            return result;
        }

        public double Factorial(double num1)
        {
            double result = 1;
            if (num1 < 0)
            {
                throw new ArgumentException();
            } else
            {
                while (num1 != 0)
                {
                    result = result * num1;
                    num1--;
                }
                if (result > Int32.MaxValue)
                {
                    throw new ArgumentException();
                }
            }
            return result;
        }

        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (0.5 * num1 * num2);
        }

        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return (Math.PI * num1 * num1);
        }

        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }
    }

}
