using RailCommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailCommander.Controllers
{
    public class BilletController : Controller
    {
        List<Station> mesStations = Models.Station.lesStations();

        // GET: Reservation
        public ActionResult Search()
        {
            //List<Station> myStation = new List<Station>();
            var query = (from station in mesStations
                         select station).ToList();

            if(query.Count() == 0)
            {
                return RedirectToAction("Home", "Home");
            }

            return View(query);
        }

        /*[HttpPost]
        public ActionResult Search()
        {

        }*/
    }
}