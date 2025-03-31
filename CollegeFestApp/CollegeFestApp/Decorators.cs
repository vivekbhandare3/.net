using System;

namespace CollegeFestApp
{
    public class Decorators
    {
        public int CalculateDecorationCost(int numPeople)
        {
            int decorationCost = 10000 + (10 * numPeople);
            Console.WriteLine($"Decoration Cost: Rs. {decorationCost}");
            return decorationCost;
        }
    }
}
