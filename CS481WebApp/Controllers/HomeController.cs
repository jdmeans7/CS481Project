using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS481WebApp.Models;

namespace CS481WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // ToDo: Remove once transitioned from JS
        public ActionResult API()
        {
            return View();
        }

        // ToDo: Remove once transitioned from JS
        public ActionResult WeatherJS()
        {
            return View();
        }

        // ToDo: Remove once transitioned from JS
        public ActionResult WeatherOrNot()
        {
            return View();
        }


        public ActionResult FeedJS()
        {
            return View();
        }

        // ToDo: Remove once transitioned from JS
        public ActionResult News()
        {
            return View();
        }

        // ToDo: Remove once transitioned from JS
        public ActionResult Exchange()
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}