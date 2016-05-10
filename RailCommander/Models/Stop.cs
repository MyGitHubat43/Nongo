using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Stop
    {
        private int id;
        private Train train;
        private Station station;

        public Stop(int id, Train train, Station station)
        {
            this.id = id;
            this.train = train;
            this.station = station;
        }

        public Stop() { }

        public int ID { get; set; }
        public Train Train { get; set; }
        public Station Station { get; set; }
    }
}