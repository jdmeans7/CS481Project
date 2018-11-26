using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class WeatherAPI
    {

        public static string GetWeatherFistHalf = "http://api.openweathermap.org/data/2.5/weather?zip=";
        public static string GetWeatherSecondHalf = ",us&APPID=26a2a5859fcf778dbe8fc240344ac11d&units=imperial";


        // Input: Send a given zipcode to get the weather
        // Returns: Weather Object
        public static QuickType.Weather GetWeatherForZipCode(string zipCode)
        {
            var apiEndPoint = GetWeatherFistHalf + zipCode + GetWeatherSecondHalf;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.Weather.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}