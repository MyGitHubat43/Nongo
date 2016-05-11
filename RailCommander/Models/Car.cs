using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Car
    {
        private int id;
        private int numberPlace;
        private Train train;

        public Car(int id, int numberPlace, Train train)
        {
            this.id = id;
            this.numberPlace = numberPlace;
            this.train = train;
            //tu pue
        }

        public Car() { }

        public int ID { get; set; }
        public int NumberPlace { get; set; }
        public Train Train { get; set; }
    }
}