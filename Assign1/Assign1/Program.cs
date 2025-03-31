using System;

namespace Assign1
{
    class Program  // Class is required inside a namespace
    {
        static void Main(string[] args)  // Main method inside class
        {
            while (true) // Infinite loop until user chooses exit
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Swap first and last character of a string.");
                Console.WriteLine("2. Calculate the sum of digits of an integer.");
                Console.WriteLine("3. Exit.");
                Console.Write("Enter your choice (1, 2, or 3): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SwapCharacters();
                        break;
                    case 2:
                        SumOfDigits();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;  // Exits the program
                    default:
                        Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                        break;
                }
            }
        }

        static void SwapCharacters()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("String must have at least 2 characters.");
                return;
            }

            // Swapping first and last character
            char first = input[0];
            char last = input[input.Length - 1];
            string result = last + input.Substring(1, input.Length - 2) + first;

            Console.WriteLine("Modified string: " + result);
        }

        static void SumOfDigits()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;  // Extract last digit and add to sum
                num /= 10;        // Remove last digit
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
    }
