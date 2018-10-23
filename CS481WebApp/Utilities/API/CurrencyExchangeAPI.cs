using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Utilities.API
{
    public static class CurrencyExchangeAPI
    {
        public static string GeneralCurrencyDetails = "https://api.exchangeratesapi.io/latest?base=";

        //TODO: Find an API endpoint to get valid currency identifiers

        // Input: Send a given currency identifier and return a currency converter object, for example USD
        // Returns: Currency Object
        public static QuickType.CurrencyConverter GetCurrencyDetails(string currencyIdentifier)
        {

            var apiEndPoint = GeneralCurrencyDetails + currencyIdentifier;
            var resultOfAPICall = APIHelper.SendHttpRequestAndGetResult(apiEndPoint);
            var getObject = QuickType.CurrencyConverter.FromJson(resultOfAPICall);

            return getObject;
        }
    }
}