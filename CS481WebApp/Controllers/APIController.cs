using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CS481WebApp.Controllers
{
    public class APIController : Controller
    {


        // GET: APITest
        public ActionResult Index()
        {
            return View();
        }

        // Send the Zip code to get weather
        // Test: /APITest/Currency?zipCode=25705
        public ActionResult Weather(string zipCode)
        {
            var result = CS481WebApp.Utilities.API.WeatherAPI.GetWeatherForZipCode(zipCode);
            return View(result);
        }

        // Send the Currency Rate
        // Test: /APITest/Currency?exchangeRate=USD
        public ActionResult Currency(string exchangeRate)
        {
            var result = CS481WebApp.Utilities.API.CurrencyExchangeAPI.GetCurrencyDetails(exchangeRate);
            return View(result);
        }


        // Send the query to get result
        // Test: /APITest/DuckDuckGo?query=Amazon
        public ActionResult DuckDuckGo(string query)
        {
            var result = CS481WebApp.Utilities.API.DuckDuckGoAPI.GetDuckDuckGoResponse(query);
            return View(result);
        }

        // Get the news
        // Test: /APITest/News
        public ActionResult News()
        {
            var result = CS481WebApp.Utilities.API.NewsAPI.GetNews();
            return View(result);
        }

        // Get the Marshall Feed
        // Test: /APITest/Marshall
        public ActionResult Marshall()
        {
            var result = CS481WebApp.Utilities.API.MarshallNewsFeedAPI.GetNews();
            return View(result);
        }

        // Get the news
        // Test: /APITest/News
        public ActionResult Reddit()
        {
            var result = CS481WebApp.Utilities.API.NewsAPI.GetNews();
            return View(result);
        }
    }
}