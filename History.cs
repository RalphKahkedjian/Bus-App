using System;
using System.Collections.Generic;

namespace YandexBus
{

    // Declared a class History Manager that inherits the interface IHistoryManager
    public class HistoryManager : IHistoryManager
    {
        // Readonly list since we can only see the historyy
        private readonly List<string> history = new List<string>();

        // If successfully booked, we add into history
        public void AddBooking(string driverName, int busId, Location location)
        {
            string entry = $"Driver: {driverName}, Bus ID: {busId}, Location: {location}";
            history.Add(entry);
            // add to list
        }

        // function to show
        public void ShowHistory()
        {
            // if npothing added to the list, the count wil be zero
            if (history.Count == 0)
            {
                Console.WriteLine("\nNo booking history available.");
                return;
            }

            Console.WriteLine("\nBooking History:");
            // for each obj inside that list, we will display it
            foreach (var entry in history)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
