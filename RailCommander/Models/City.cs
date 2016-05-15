using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class City
    {
        private int id;
        private String name;
        private String department;

        public City(int id, String name, String department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public City() { }

        public int ID { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
    }
}