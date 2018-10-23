using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CS481WebApp.Controllers
{
    public class APITestController : Controller
    {



        // GET: APITest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Weather()
        {
            // var welcome = Welcome.FromJson(jsonString);
            // https://samples.openweathermap.org/data/2.5/weather?zip=25705,us&appid=b6907d289e10d714a6e88b30761fae22
            return View();

        }

        // Send the Currency Rate
        // Test: http://localhost:55133/APITest/Currency?exchangeRate=USD
        public ActionResult Currency(string exchangeRate)
        {
            var result = CS481WebApp.Utilities.API.CurrencyExchangeAPI.GetCurrencyDetails(exchangeRate);
            return View(result);
        }
    }
}