using System;

namespace CollegeFestApp
{
    public class Caterers
    {
        public int CalculateCateringCost(int numPeople)
        {
            int cateringCost = numPeople * 200;
            Console.WriteLine($"Catering Cost: Rs. {cateringCost}");
            return cateringCost;
        }
    }
}
