using System;

class TypeCastingProgram
{
    static void Main()
    {
        Console.Write("Give an input in order to typecast: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine($"Integer value: {intValue}");
        }
        else
        {
            Console.WriteLine("Input is not a valid integer.");
        }

        if (bool.TryParse(input, out bool boolValue))
        {
            Console.WriteLine($"Boolean value: {boolValue}");
        }
        else
        {
            Console.WriteLine("Input is not a valid boolean.");
        }

        if (double.TryParse(input, out double doubleValue))
        {
            Console.WriteLine($"Double value: {doubleValue}");
        }
        else
        {
            Console.WriteLine("Input is not a valid double.");
        }

        if (decimal.TryParse(input, out decimal decimalValue))
        {
            Console.WriteLine($"Decimal value: {decimalValue}");
        }
        else
        {
            Console.WriteLine("Input is not a valid decimal.");
        }

        if (DateTime.TryParse(input, out DateTime dateTimeValue))
        {
            Console.WriteLine($"DateTime value: {dateTimeValue}");
        }
        else
        {
            Console.WriteLine("Input is not a valid DateTime.");
        }
    }
}
