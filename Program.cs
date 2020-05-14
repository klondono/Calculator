using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using Utilities;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = "";
            var optionDescription = "None";

            // Display title as the C# console calculator app.
            Console.WriteLine("Welcome to My Program!");
            Console.WriteLine("------------------------");

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("s - String Functions");
            Console.WriteLine("m - Math Functions");
            Console.Write("Your option? ");
            option = Console.ReadLine();

            switch (option)
            {
                case "s":
                    optionDescription = "String Manipulator";
                    ExecuteStringManipulator();
                    break;
                case "m":
                    optionDescription = "Calculator";
                    ExecuteCalculator();
                    break;
                default:
                    Console.Write("Invalid Option.  Press any key to close.");
                    Console.ReadKey();
                    break;
            }

            // Wait for the user to respond before closing.
            Console.Write($"Press any key to close the {optionDescription} console app...");
            Console.ReadKey();
        }

        private static void ExecuteStringManipulator()
        {
            string option;
            var stringToAlter = "";

            Console.WriteLine("Input a word, and then press Enter");
            stringToAlter = Console.ReadLine();

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("u - Uppercase");
            Console.WriteLine("r - Reverse");
            Console.WriteLine("pb - Print Backwards");
            Console.WriteLine("s - Letter Search");
            //Console.WriteLine("p - Palindrome");
            Console.Write("Your option? ");
            option = Console.ReadLine();

            var strUtil = new StringUtil();
            var result = "";

            switch (option)
            {
                case "u":
                    result = strUtil.Capitalize(stringToAlter);
                    Console.WriteLine($"Your result for: {stringToAlter} = " + result);
                    break;
                case "r":
                    result = strUtil.Reverse(stringToAlter);
                    Console.WriteLine($"Your result for: {stringToAlter} = " + result);
                    break;
                case "pb":
                    strUtil.PrintBackwards(stringToAlter);
                    Console.WriteLine("Done.");
                    break;
                case "s":
                    Console.Write("Specify letter to search for:");
                    var letter = Convert.ToChar(Console.ReadLine());
                    var hasLetter = strUtil.HasLetter(stringToAlter, letter);

                    if (hasLetter)
                    {
                        Console.WriteLine($"Letter {letter} is included in the word: " + stringToAlter);
                    }
                    else
                    {
                        Console.WriteLine($"Letter {letter} is NOT included in the word: " + stringToAlter);
                    }

                    break;
                default:
                    var msg = "Invalid selection";
                    Console.WriteLine(msg);
                    break;
            }
        }

        private static void ExecuteCalculator()
        {
            string option;
            // Declare variables and then initialize to zero.
            double num1 = 0;
            double num2 = 0;

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("a - Add");
            Console.WriteLine("s - Subtract");
            Console.WriteLine("m - Multiply");
            Console.WriteLine("d - Divide");
            Console.WriteLine("q - Square Root");
            Console.Write("Your option? ");
            option = Console.ReadLine();
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            if (option != "q")
            {
                // Ask the user to type the second number.
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            var math = new MathUtil();

            // Use a switch statement to do the math.
            switch (option)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + math.Add(num1, num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + math.Subtract(num1, num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + math.Multiply(num1, num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + math.Divide(num1, num2));
                    break;
                case "q":
                    Console.WriteLine($"Your result: Sq Root of {num1} = " + math.SquareRoot(num1));
                    break;
                default:
                    var msg = "Invalid selection";
                    Console.WriteLine(msg);
                    break;
            }
        }
    }
}
