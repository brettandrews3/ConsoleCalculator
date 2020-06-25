using System;

namespace NewCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false; //Is this app over? No!
            //First up, here's the app's title:
            Console.WriteLine("Brett's C# Console Calculator\r");
            Console.WriteLine("-----------------------------\n");

            while (!endApp) //So long as the app is running:
            {
                //Toss in some empty variables. Make 'em string for flexibility:
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //Ask user for the first number
                Console.WriteLine("Welcome! Enter your first number here, then press Enter: ");
                numInput1 = Console.ReadLine();

                //cleanNum var catches any invalid user inputs, asks again for an integer
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Invalid input. Give me an integer value, please: ");
                    numInput1 = Console.ReadLine();
                }

                //Ask user for the second number
                Console.WriteLine($"That first number is {numInput1}. Enter that second number here: ");
                numInput2 = Console.ReadLine();

                //cleanNum var catches any invalid user inputs, asks again for an integer
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine($"{cleanNum2} is invalid input. Give an integer value, please: ");
                    numInput2 = Console.ReadLine();
                }

                //Ask the user for which operator they want to use:
                Console.WriteLine("-----------------------------\n");
                Console.WriteLine("Alright! Now, choose an operator from this list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\to - Modulus");
                Console.Write("Which one do you choose? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.Do0peration(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation results in a mathematical error. \n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops! An exception popped up while doing the math. \n" +
                        " - Details: " + e.Message);
                }

                Console.WriteLine("-----------------------------\n");

                //Wait for user input before closing the app
                Console.Write("Nice job. Press 'n' and Enter to close the app, or press" +
                    "any other key and Enter to go again: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); //A little friendly line spacing
            }
            return; //Now, let's take it from the top!
        }

    }
}

/* Original code:
 * {            // Declare our variables and initialize to 0:
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
                    //Ask user to enter a nonzero divisor until they comply
                    while(num2 == 0)
                    {
                        Console.WriteLine("I can't divide by zero. Pick another number, please:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your quotient: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "o":
                    while (num2 == 0)
                    {
                        Console.WriteLine("I can't divide by zero. Pick another number, please:");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your remainder: {num1} % {num2} = " + (num1 % num2));
                    break;
            }

            //Finally, let the user respond to the console before ending the program
            Console.WriteLine("------------------");
            Console.Write("Excellent! Press any key to close the C# Console Calculator app.");
            Console.ReadKey();
        } */