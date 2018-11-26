using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class DuckDuckGoAPI
    {
        public static string DuckDuckGoEndpointPart1 = "https://api.duckduckgo.com/?q=";
        public static string DuckDuckGoEndpointPart2 = "&format=json&pretty=1";


        // Input: Send a given query and recive a duck duck go response
        // Returns: Duck Duck Go Object
        public static QuickType.DuckDuckGo GetDuckDuckGoResponse(string duckDuckGoQuery)
        {
            var apiEndPoint = DuckDuckGoEndpointPart1 + duckDuckGoQuery + DuckDuckGoEndpointPart2;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.DuckDuckGo.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}