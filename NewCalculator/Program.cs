using System;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare our variables and initialize to 0:
            int num1 = 0; int num2 = 0;

            //Display title of the console app:
            Console.WriteLine("Brett's C# Console Calculator\r");
            Console.WriteLine("-----------------------------\n");

            //Ask user to type their first number:
            Console.WriteLine("Enter a number here, then press Enter:");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Ask user for the second number:
            Console.WriteLine($"Your first number is {num1}. What's your second number?");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
