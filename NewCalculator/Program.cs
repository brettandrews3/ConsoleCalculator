using System;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare our variables and initialize to 0:
            double num1 = 0; double num2 = 0;

            //Display title of the console app:
            Console.WriteLine("Brett's C# Console Calculator\r");
            Console.WriteLine("-----------------------------\n");

            //Ask user to type their first number:
            Console.WriteLine("Enter your first number here, then press Enter:");
            num1 = Convert.ToDouble(Console.ReadLine());

            //Ask user for the second number:
            Console.WriteLine($"Your first number is {num1}. What's your second number?");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------");

            //Now, we ask the user to pick an operand:
            Console.WriteLine($"Okay, I've got {num1} and {num2} lined up.");
            Console.WriteLine("Now, select which calculation you want to do:");

            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\to - Modulus");

            //This switch statement will do the math for us:
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your sum: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your product: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your quotient: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "o":
                    Console.WriteLine($"Your remainder: {num1} % {num2} = " + (num1 % num2));
                    break;
            }

            //Finally, let the user respond to the console before ending the program
            Console.WriteLine("------------------");
            Console.Write("Excellent! Press any key to close the C# Console Calculator app.");
            Console.ReadKey();
        }
    }
}
