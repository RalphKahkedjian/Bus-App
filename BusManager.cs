using System;
using System.Collections.Generic;

namespace YandexBus
{
    // Created static class BusManager
    public static class BusManager
    {
        // Declared Dictionary of key Location and value Bus ( which we will initialize the constructor.
        public static Dictionary<Location, List<Bus>> busesByLocation = new Dictionary<Location, List<Bus>>();

        public static void InitializeBuses()
        {
            // If user chooses Yerevan as his/her locationn
            List<Bus> yerevanBuses = new List<Bus>
            {
                new TourBus("Arman", 101, 40, Status.Available, Location.Yerevan, 5, "Luxury"),
                new PublicTransportBus("Narek", 102, 35, Status.FullyBooked, Location.Yerevan, 3, "Standard"),
                new TourBus("Varadzat", 103, 50, Status.Available, Location.Yerevan, 7, "Luxury"),
                new PublicTransportBus("Henrikh", 104, 30, Status.Available, Location.Yerevan, 2, "Economy"),
                new PublicTransportBus("Karen", 105, 40, Status.FullyBooked, Location.Yerevan, 4, "Standard"),
                new PublicTransportBus("Mery", 106, 45, Status.Available, Location.Yerevan, 5, "Economy")
            };

            // If user chooses Tbilisi as his/her location
            List<Bus> tbilisiBuses = new List<Bus>
            {
                new PublicTransportBus("Giorgi", 201, 45, Status.Available, Location.Tbilisi, 4, "Standard"),
                new TourBus("Mariam", 202, 55, Status.FullyBooked, Location.Tbilisi, 6, "Luxury"),
                new PublicTransportBus("Tamar", 203, 60, Status.Available, Location.Tbilisi, 5, "Standard"),
                new TourBus("Nikoloz", 204, 50, Status.Available, Location.Tbilisi, 7, "Luxury"),
                new PublicTransportBus("Sopo", 205, 35, Status.Available, Location.Tbilisi, 3, "Economy"),
                new PublicTransportBus("Davit", 206, 40, Status.FullyBooked, Location.Tbilisi, 4, "Standard")
            };

            // If user chooses Moscow as his/her locationn
            List<Bus> moscowBuses = new List<Bus>
            {
                new TourBus("Sergey", 301, 50, Status.Available, Location.Moscow, 8, "Luxury"),
                new PublicTransportBus("Olga", 302, 40, Status.FullyBooked, Location.Moscow, 5, "Standard"),
                new TourBus("Dmitry", 303, 60, Status.Available, Location.Moscow, 10, "Luxury"),
                new PublicTransportBus("Ivan", 304, 35, Status.Available, Location.Moscow, 4, "Economy"),
                new PublicTransportBus("Natasha", 305, 50, Status.FullyBooked, Location.Moscow, 5, "Standard"),
                new PublicTransportBus("Oleg", 306, 45, Status.Available, Location.Moscow, 6, "Economy")
            };

            // for each location enum chosen, it will display depending on the location chosen
            busesByLocation[Location.Yerevan] = yerevanBuses;
            busesByLocation[Location.Tbilisi] = tbilisiBuses;
            busesByLocation[Location.Moscow] = moscowBuses;
        }

        public static List<Bus> GetBusesByLocationAndType(Location location, string busType)
        {
            // Check if the location exists in the dictionary
            if (!busesByLocation.ContainsKey(location))
            {
                Console.WriteLine($"Error: No buses found for the location {location}.");
                return new List<Bus>();
            }

            List<Bus> availableBuses = new List<Bus>();

            // For each bus in that location chosen by the user...

            foreach (var bus in busesByLocation[location])
            {
                // this checks if the string input is tour or public
                if (busType.Equals("tour", StringComparison.OrdinalIgnoreCase) && bus is TourBus ||
                    busType.Equals("public", StringComparison.OrdinalIgnoreCase) && bus is PublicTransportBus)
                {
                    availableBuses.Add(bus);
                }
            }

            return availableBuses;
        }
    }
}
