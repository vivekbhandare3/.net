using System;

class StringManipulationProgram
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string upperCase = input.ToUpper();
        string lowerCase = input.ToLower();
        string trimmed = input.Trim();
        string replaced = input.Replace('l', '*');

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'l')
            {
                count++;
            }
        }

        string formattedOutput = string.Join("*", input.ToCharArray());

        Console.WriteLine($"Uppercase: {upperCase}");
        Console.WriteLine($"Lowercase: {lowerCase}");
        Console.WriteLine($"Trimmed: '{trimmed}'");
        Console.WriteLine($"Replaced 'l' with '*': {replaced}");
        Console.WriteLine($"Number of 'l' in the string: {count}");
        Console.WriteLine($"Formatted output: {formattedOutput}");
    }
}
