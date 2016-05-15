using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Ticket
    {
        private int id;
        private Train train;
        private User user;
        private Car car;
        private Seat seat;
        private Station stationStart;
        private Station stationEnd;
        private DateTime dateDepart;
        private DateTime dateArrivee;
        private String heureDepart;
        private String heureArrivee;
        private City villeDepart;
        private City villeArrivee;
        private int tempsTrajet;
        private Double prix;

        public Ticket(int id, Train train, User user, Car car, Seat seat, Station stationStart, Station stationEnd, DateTime dateDepart, DateTime dateArrivee, String heureDepart, String heureArrivee, City villeDepart, City villeArrivee, int tempsTrajet, double prix)
        {
            this.id = id;
            this.train = train;
            this.user = user;
            this.car = car;
            this.seat = seat;
            this.stationStart = stationStart;
            this.stationEnd = stationEnd;
            this.dateDepart = dateDepart;
            this.dateArrivee = dateArrivee;
            this.heureDepart = heureDepart;
            this.heureArrivee = heureArrivee;
            this.villeDepart = villeDepart;
            this.villeArrivee = villeArrivee;
            this.tempsTrajet = tempsTrajet;
            this.prix = prix;
        }

        public Ticket() { }

        public int ID { get; set; }
        public Train Train { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
        public Seat Seat { get; set; }
        public Station StationStart { get; set; }
        public Station StationEnd { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public String HeureStart { get; set; }
        public String HeureEnd { get; set; }
        public City CityStart { get; set; }
        public City CityEnd { get; set; }
        public int TempsTrajet { get; set; }
        public Double Price { get; set; }

    }
}