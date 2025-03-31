using System;
using System.IO;

public class FileDirectoryInfo
{
    public static void Run()
    {
        string dirPath = "."; // Current directory

        // Get directory info
        DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
        Console.WriteLine("Directory Info:");
        Console.WriteLine($"Full Name: {dirInfo.FullName}");
        Console.WriteLine($"Created On: {dirInfo.CreationTime}");

        // Get file info
        FileInfo[] files = dirInfo.GetFiles();
        Console.WriteLine("\nFiles in Directory:");
        foreach (FileInfo file in files)
        {
            Console.WriteLine($"File: {file.Name}, Size: {file.Length} bytes");
        }
    }
}
