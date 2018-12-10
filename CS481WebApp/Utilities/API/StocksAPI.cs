using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class StocksAPI
    {
        public static string StockDataOne = "https://api.iextrading.com/1.0/stock/";
        public static string StockDataTwo = "/batch?types=quote,news,chart&range=1m&last=10";


        // Input: Send a given stock identifier and return information on it
        // Returns: Stock Object
        public static QuickType.Stocks GetStockDetails (string stockIdentifier)
        {

            var apiEndPoint = StockDataOne + stockIdentifier + StockDataTwo;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.Stocks.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}