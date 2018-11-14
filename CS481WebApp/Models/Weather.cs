using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace CS481WebApp.Models
{
	class Weather
	{
		public Object getWeatherForcast()
		{
			string url ="http://api.openweathermap.org/data/2.5/weather?zip=25701,us&APPID=26a2a5859fcf778dbe8fc240344ac11d&units=imperial";
			var client = new WebClient();
			var content = client.DownloadString(url);
			var serializer = new JavaScriptSerializer();
			var jsonContent = serializer.Deserialize<Object>(content);
			return jsonContent;
		}
	}
}