using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            double num1 = 0;
            double num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Calculator");
            Console.WriteLine("------------------------");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");

            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("a - Add");
            Console.WriteLine("s - Subtract");
            Console.WriteLine("m - Multiply");
            Console.WriteLine("d - Divide");
            Console.Write("Your option? ");

            var option = Console.ReadLine();

            if (option == "a")
            {
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            }
            else if (option == "s")
            {
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            }
            else if (option == "m")
            {
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            }
            else if (option == "d")
            {
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }

            var name = "Hi";
            var name2 = "Sam";

            var test = name + " " + name2;


            var greetingWithName = string.Format("Hello {0} and {1}", name, name2);

            greetingWithName = $"Hello {name} and {name2}";

            // Use a switch statement to do the math.
            switch (option)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
