using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexBus
{
    public abstract class Bus
    {
        public string driver { get; set; }
        public int ID { get; set; }
        public int capacity { get; set; }
        public Status status { get; set; }
        public Location location { get; set; }
        public Bus(string d, int i, int c, Status s, Location l)
        {
            driver = d;
            ID = i;
            capacity = c;
            status = s;
            location = l;
        }

        public abstract void DisplayInfo();

    }
}
