using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class MarshallNewsFeedAPI
    {
        public static string MarshallFeedAPIEndpoint = "https://mumobileprod.marshall.edu/banner-mobileserver/rest/1.2/feed";

        // Input: Get Marshall news of the day
        // Returns: Marshall News Object
        public static QuickType.MarshallNewsFeed GetNews()
        {
            var apiEndPoint = MarshallFeedAPIEndpoint;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.MarshallNewsFeed.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}