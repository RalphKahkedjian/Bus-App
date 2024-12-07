using System;
using System.Collections.Generic;
using System.Threading;

namespace YandexBus
{
    public static class Booking
    {
        private static readonly IHistoryManager HistoryManager = new HistoryManager();

        public static void BookBus()
        {
            // Initialize buses before starting the booking process
            BusManager.InitializeBuses();

            // The user chooses his/her location
            Console.WriteLine("\nChoose Location:");
            Console.WriteLine("1. Yerevan");
            Console.WriteLine("2. Tbilisi");
            Console.WriteLine("3. Moscow");
            int locationInput = Convert.ToInt32(Console.ReadLine());
            Location selectedLocation = (Location)(locationInput - 1);

            Console.WriteLine("\nChoose Bus Type:");
            Console.WriteLine("1. Tour");
            Console.WriteLine("2. Public");
            int busTypeInput = Convert.ToInt32(Console.ReadLine());
            string selectedBusType = busTypeInput == 1 ? "tour" : "public";

            // Get buses by location and type
            List<Bus> availableBuses = BusManager.GetBusesByLocationAndType(selectedLocation, selectedBusType);

            if (availableBuses.Count == 0)
            {
                Console.WriteLine("\nNo buses available for the selected location and type.");
                return;
            }

            Console.WriteLine($"\nAvailable {selectedBusType} buses in {selectedLocation}:");
            foreach (var bus in availableBuses)
            {
                Console.WriteLine($"ID: {bus.ID}, Driver: {bus.driver}, Capacity: {bus.capacity}, Status: {bus.status}");
            }

            Console.WriteLine("\nEnter the Bus ID to book:");
            int busId = Convert.ToInt32(Console.ReadLine());

            // Find and book the bus
            var busToBook = availableBuses.Find(bus => bus.ID == busId);
            if (busToBook != null && busToBook.status == Status.Available)
            {
                // Simulate bus arrival
                Console.WriteLine("\nThe bus is arriving...");
                Thread.Sleep(5000);

                // Change bus status to booked
                busToBook.status = Status.FullyBooked;
                Console.WriteLine($"Successfully booked Bus ID: {busToBook.ID}, Driver: {busToBook.driver}");

                // Add booking details to history
                HistoryManager.AddBooking(busToBook.driver, busToBook.ID, selectedLocation);
            }
            else
            {
                Console.WriteLine("\nError: Bus is either not available or already fully booked.");
            }

            // Delay before clearing the console
            Thread.Sleep(2200);
            Console.Clear();
        }

        // we willl use that function in the main file to display the history
        public static void ViewBookingHistory()
        {
            HistoryManager.ShowHistory();
        }
    }
}
