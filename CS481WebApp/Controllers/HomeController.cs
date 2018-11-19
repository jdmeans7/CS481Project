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

        public ActionResult API()
        {
            return View();
        }

        public ActionResult WeatherJS()
        {
            return View();
        }

        public ActionResult WeatherOrNot()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            Weather weath = new Weather();
            return Json(weath.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult FeedJS()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

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