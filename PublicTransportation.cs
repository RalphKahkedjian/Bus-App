using System;

namespace YandexBus
{
    public class PublicTransportBus : Bus, IBusAttributes
    {
        public int DriverExperience { get; set; } 
        public string BusType { get; set; } 

        public PublicTransportBus(string driver, int id, int capacity, Status status, Location location, int driverExperience, string busType)
            : base(driver, id, capacity, status, location)
        {
            DriverExperience = driverExperience;
            BusType = busType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Public Transport Bus - Driver: {base.driver}, ID: {base.ID}, Capacity: {base.capacity}, Status: {base.status}, Location: {base.location}, Experience: {DriverExperience} years, Type: {BusType}");
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Bus Type: {BusType}, Driver Experience: {DriverExperience} years");
        }
    }
}
