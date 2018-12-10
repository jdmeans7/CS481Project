using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CS481WebApp.Controllers
{
    [Authorize]
    public class APIController : Controller
    {


        // GET: APITest
        public ActionResult Index()
        {
            return View();
        }


        // Simple form for Stock
        public ActionResult StocksForm()
        {
            return View();
        }

        // Send the stock to get weather
        // Test: /APITest/Stock?stockIdentifier=MSFT
        public ActionResult Stocks(string stockIdentifier = "MSFT")
        {
            if (stockIdentifier == null || stockIdentifier == "")
            {
                return RedirectToAction("Error", "API", new { message = "Zip Code was blank! Please select back and try again.", link = "/API/StockForm" });
            }
            var result = CS481WebApp.Utilities.API.StocksAPI.GetStockDetails(stockIdentifier);
            return View(result);
        }




        // Send the Zip code to get weather
        // Test: /APITest/Currency?zipCode=25705
        public ActionResult Weather(string zipCode = "25705")
        {
            if (zipCode == null || zipCode == "")
            {
                return RedirectToAction("Error", "API", new { message = "Zip Code was blank! Please select back and try again.", link = "/API/WeatherForm" });
            }
            var result = CS481WebApp.Utilities.API.WeatherAPI.GetWeatherForZipCode(zipCode);
            return View(result);
        }

        // Simple form for Weather
        public ActionResult WeatherForm()
        {
            return View();
        }

        // Send the Currency Rate
        // Test: /APITest/Currency?exchangeRate=USD
        public ActionResult Currency(string exchangeRate = "USD")
        {
            if (exchangeRate == null || exchangeRate == "")
            {
                return RedirectToAction("Error", "API", new{ message = "Currency was blank! Please try again.", link = "/API/CurrencyForm"});
            }

            var result = CS481WebApp.Utilities.API.CurrencyExchangeAPI.GetCurrencyDetails(exchangeRate);
            return View(result);
        }

        // Simple form for Currency
        public ActionResult CurrencyForm()
        {
            return View();
        }

        // Send the query to get result
        // Test: /APITest/DuckDuckGo?query=Amazon
        public ActionResult DuckDuckGo(string query = "Amazon")
        {
            if (query == null || query == "")
            {
                return RedirectToAction("Error", "API", new { message = "Query was blank! Please select back and try again.", link = "/API/DuckDuckGoForm" });
            }
            var result = CS481WebApp.Utilities.API.DuckDuckGoAPI.GetDuckDuckGoResponse(query);
            return View(result);
        }

        // Simple form for Duck Duck Go
        public ActionResult DuckDuckGoForm()
        {
            return View();
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

        // Something went wrong
        public ActionResult Error(string message, string link)
        {
            ViewBag.Message = message;
            ViewBag.Link = link;
            return View();
        }
    }
}