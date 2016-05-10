using RailCommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailCommander.Controllers
{
    public class UserController : Controller
    {
        List<User> mesUsers = Models.User.mesUsers();

        // GET: User
        public ActionResult Connexion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connexion(string email, string pass)
        {
            if (mesUsers.Count() == 0)
            {
                return RedirectToAction("Inscription", "User");
            }
            
            foreach(User u in mesUsers)
            {
                if(u.Email == email && u.Pass == pass)
                {
                    Session["email"] = u.Email;
                    Session["pass"] = u.Pass;
                    return RedirectToAction("Compte", "User");
                }
            }

            return View();
        }

        public ActionResult Deconnexion()
        {
            Session.RemoveAll();

            return RedirectToAction("Connexion", "User");
        }

        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inscription(User user)
        {
            DBConnect db = new DBConnect();
            db.AddUser(user);

            Session["email"] = user.Email;
            Session["pass"] = user.Pass;

            return RedirectToAction("Compte", "User");
        }

        public ActionResult Compte()
        {
            if(Session["email"] != null && Session["pass"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Connexion", "User");
            }
        }
    }
}