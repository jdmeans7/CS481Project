using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class NewsAPI
    {
        public static string NewsAPIEndpoint = "https://newsapi.org/v2/top-headlines?sources=cnn&apiKey=d3873b1722a64a9687bcccb299e06a84";

        // Input: Get news of the day
        // Returns: News Object
        public static QuickType.News GetNews()
        {
            var apiEndPoint = NewsAPIEndpoint;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.News.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}