using System;

namespace YandexBus
{

    // Inherited from the base class ( Bus ) and also the interface IBusAttributes
    public class TourBus : Bus, IBusAttributes
    {
        // Declaring attributes and the constructor 
        public int DriverExperience { get; set; } 
        public string BusType { get; set; } 

        public TourBus(string driver, int id, int capacity, Status status, Location location, int driverExperience, string busType)
            : base(driver, id, capacity, status, location)  // used the base class attributes initializations , but added two new attributes
        {
            DriverExperience = driverExperience;
            BusType = busType;
        }

        // Overrides the function DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Tour Bus - Driver: {base.driver}, ID: {base.ID}, Capacity: {base.capacity}, Status: {base.status}, Location: {base.location}, Experience: {DriverExperience} years, Type: {BusType}");
        }

        // Function that was declared in the interface

        public void ShowDetails()
        {
            Console.WriteLine($"Bus Type: {BusType}, Driver Experience: {DriverExperience} years");
        }
    }
}
