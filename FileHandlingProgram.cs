using System;
using System.IO;

class FileHandlingProgram
{
    static void Main()
    {
        string filePath = "output.txt";

        if (File.Exists(filePath))
        {
            Console.WriteLine("Current contents of the file:");
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File does not exist. A new file will be created.");
        }

        Console.Write("Enter a string to append to the file: ");
        string input = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(input);
        }

        Console.WriteLine("String appended to the file successfully.");

        Console.WriteLine("Updated contents of the file:");
        string[] updatedLines = File.ReadAllLines(filePath);
        foreach (string line in updatedLines)
        {
            Console.WriteLine(line);
        }
    }
}
