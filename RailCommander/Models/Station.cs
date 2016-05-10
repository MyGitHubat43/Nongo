using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Station
    {
        private int id;
        private String name;
        private City city;

        public Station(int id, String name, City city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

        public Station() { }

        public int ID { get; set; }
        public String Name { get; set; }
        public City City { get; set; }
    }
}