using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailCommander.Models
{
    public class Train
    {
        private int id;
        private String typeTrain;

        public Train(int id, String typeTrain)
        {
            this.id = id;
            this.typeTrain = typeTrain;
        }
        public Train() { }

        public int ID { get; set; }
        public String TypeTrain { get; set; }
    }
}