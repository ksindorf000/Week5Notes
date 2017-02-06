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

        public ActionResult FunnyJoke() 
        {
            return View();
        }

    }
}