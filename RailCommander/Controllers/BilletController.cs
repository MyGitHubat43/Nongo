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

        public String ReturnNom(String gareStartAjax, String gareEndAjax, String dateStartAjax, String dateReturnAjax, String hourStartAjax, String hourReturnAjax)
        {
            if(!String.IsNullOrEmpty(gareStartAjax) && !String.IsNullOrEmpty(gareEndAjax) && !String.IsNullOrEmpty(dateStartAjax) && !String.IsNullOrEmpty(dateReturnAjax) && !String.IsNullOrEmpty(hourStartAjax) && !String.IsNullOrEmpty(hourReturnAjax))
            {
              return "<div id='blocResult'>" + gareStartAjax + " " + gareEndAjax + " " + dateStartAjax + " " + dateReturnAjax + " " + hourStartAjax + " " + hourReturnAjax + "</div><br /><br /><input type='button' name='btnRechercherRetour' id='btnRechercherRetour' value='Suivant' />";
            }
            else
            {
                return "Vide";
            }
            
        }
    }
}