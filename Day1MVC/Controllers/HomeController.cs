using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //These are your urls and page names
        {
            return View(); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The Iron Yard - from code";
            var rng = new Random();
            ViewBag.RandomNum = rng.Next(1, 11);
            return View();
        }
    }
}