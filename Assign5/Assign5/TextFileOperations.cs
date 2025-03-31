using System;
using System.IO;

public class TextFileOperations
{
    public static void Run()
    {
        string filePath = "testfile.txt";

        // Writing to file
        File.WriteAllText(filePath, "Hello, this is a text file.\n");

        // Appending to file
        File.AppendAllText(filePath, "This is an appended line.\n");

        // Reading from file
        string content = File.ReadAllText(filePath);
        Console.WriteLine("File Contents:\n" + content);
    }
}
