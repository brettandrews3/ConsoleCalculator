using System;
namespace NewCalculator
{
    public class Calculator
    {
        public static double Do0peration(double num1, double num2, string op)
        {
            double result = double.NaN; //Default value is "not-a-number"

            //switch statement does the math here:
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    result = num1 / num2;
                    break;
                case "o":
                    result = num1 % num2;
                    break;
                // Return the text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
}
