using System;

namespace CollegeFestApp
{
    // Step 1: Define the delegate
    public delegate int CollegeFestHandler(int numPeople);

    public class College
    {
        // Step 2: Define the event
        public event CollegeFestHandler CollegeFestEvent;

        // Step 3: Method to trigger the event
        public int OnCollegeFestEvent(int numPeople)
        {
            int totalCost = 0;
            if (CollegeFestEvent != null)
            {
                foreach (CollegeFestHandler handler in CollegeFestEvent.GetInvocationList())
                {
                    totalCost += handler.Invoke(numPeople);
                }
            }
            return totalCost;
        }
    }
}
