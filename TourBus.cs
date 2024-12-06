using System;

namespace YandexBus
{
    public class TourBus : Bus
    {
        public TourBus(string driver, int id, int capacity, Status status, Location location)
            : base(driver, id, capacity, status, location)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tour Bus - {base.driver}\nID: {base.ID}\nCapacity: {base.capacity}\nStatus: {base.status}\nLocation: {base.location}\n");
        }
    }
}
