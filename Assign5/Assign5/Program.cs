using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nFile Operations Menu:");
            Console.WriteLine("1. Read, Write, and Append Text File");
            Console.WriteLine("2. Read and Write Binary File");
            Console.WriteLine("3. Get File and Directory Info");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TextFileOperations.Run();
                    break;
                case "2":
                    BinaryFileOperations.Run();
                    break;
                case "3":
                    FileDirectoryInfo.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
