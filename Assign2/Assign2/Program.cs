using System;
using MyOperations; // Import the custom library

namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Perform Division");
                Console.WriteLine("2. Access Array Element");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        HandleDivision();
                        break;
                    case 2:
                        HandleArrayAccess();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;
                }
            }
        }

        static void HandleDivision()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter denominator: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = MyOperationsClass.Divide(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex}");
            }
        }

        static void HandleArrayAccess()
        {
            try
            {
                int[] arr = { 10, 20, 30 };
                Console.Write("Enter index to access: ");
                int index = Convert.ToInt32(Console.ReadLine());

                int element = MyOperationsClass.GetElement(arr, index);
                Console.WriteLine($"Element at index {index}: {element}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex}");
            }
        }
    }
}
