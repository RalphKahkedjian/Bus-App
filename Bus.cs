using System;
using System.Collections.Generic;

namespace YandexBus
{

    public abstract class Bus
    {

        //Declaring attributes for the Bus and its constructor
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

        // To display the info of the bus, and it will be overridden in the inherited classes
        public abstract void DisplayInfo();
    }
}
