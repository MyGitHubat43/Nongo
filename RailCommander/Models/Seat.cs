using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Seat
    {
        private int id;
        private Boolean reserve;
        private int classe;
        private Car car;

        public Seat(int id, Boolean reserve, int classe, Car car)
        {
            this.id = id;
            this.reserve = reserve;
            this.classe = classe;
            this.car = car;
        }

        public Seat() { }

        public int ID { get; set; }
        public Boolean Reserve { get; set; }
        public int Classe { get; set; }
        public Car Car { get; set; }
    }
}