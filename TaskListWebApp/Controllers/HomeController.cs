using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaskListWebApp.Models;

namespace TaskListWebApp.Controllers
{
    public class HomeController : Controller
    {
        private DbUser db = new DbUser();
        private DbTask db2 = new DbTask();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string email, string password)
        {
            User user = new User();
            for (int i = 1; i < 3 ; i++)
            {
                user = db.Users.Find(i);
                if ( user.Email == email)
                {
                    break;
                }
            }
            
            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (password == user.Password)
            {
                Session["Logged In"] = user.Email;
                return RedirectToAction("Index", "Tasks");
            }
            else
            {
                return RedirectToAction("Welcome");
            }
            
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}