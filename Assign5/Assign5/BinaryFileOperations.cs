using System;
using System.IO;

public class BinaryFileOperations
{
    public static void Run()
    {
        string filePath = "binaryfile.dat";

        // Writing binary data
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(12345);
            writer.Write(3.1415);
            writer.Write("Binary File Example");
        }

        // Reading binary data
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int number = reader.ReadInt32();
            double pi = reader.ReadDouble();
            string text = reader.ReadString();
            Console.WriteLine($"Read from binary file:\nNumber: {number}, Pi: {pi}, Text: {text}");
        }
    }
}
