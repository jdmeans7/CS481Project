﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var stocks = Stocks.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Stocks
    {
        [JsonProperty("quote")]
        public Quote Quote { get; set; }

        [JsonProperty("news")]
        public News[] News { get; set; }

        [JsonProperty("chart")]
        public Chart[] Chart { get; set; }
    }

    public partial class Chart
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("unadjustedVolume")]
        public long UnadjustedVolume { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("changePercent")]
        public double ChangePercent { get; set; }

        [JsonProperty("vwap")]
        public double Vwap { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("changeOverTime")]
        public double ChangeOverTime { get; set; }
    }

    public partial class News
    {
        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }
    }

    public partial class Quote
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("primaryExchange")]
        public string PrimaryExchange { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("calculationPrice")]
        public string CalculationPrice { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("openTime")]
        public long OpenTime { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("closeTime")]
        public long CloseTime { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("latestPrice")]
        public double LatestPrice { get; set; }

        [JsonProperty("latestSource")]
        public string LatestSource { get; set; }

        [JsonProperty("latestTime")]
        public string LatestTime { get; set; }

        [JsonProperty("latestUpdate")]
        public long LatestUpdate { get; set; }

        [JsonProperty("latestVolume")]
        public long LatestVolume { get; set; }

        [JsonProperty("iexRealtimePrice")]
        public object IexRealtimePrice { get; set; }

        [JsonProperty("iexRealtimeSize")]
        public object IexRealtimeSize { get; set; }

        [JsonProperty("iexLastUpdated")]
        public object IexLastUpdated { get; set; }

        [JsonProperty("delayedPrice")]
        public double DelayedPrice { get; set; }

        [JsonProperty("delayedPriceTime")]
        public long DelayedPriceTime { get; set; }

        [JsonProperty("extendedPrice")]
        public double ExtendedPrice { get; set; }

        [JsonProperty("extendedChange")]
        public double ExtendedChange { get; set; }

        [JsonProperty("extendedChangePercent")]
        public double ExtendedChangePercent { get; set; }

        [JsonProperty("extendedPriceTime")]
        public long ExtendedPriceTime { get; set; }

        [JsonProperty("previousClose")]
        public double PreviousClose { get; set; }

        [JsonProperty("change")]
        public double Change { get; set; }

        [JsonProperty("changePercent")]
        public double ChangePercent { get; set; }

        [JsonProperty("iexMarketPercent")]
        public object IexMarketPercent { get; set; }

        [JsonProperty("iexVolume")]
        public object IexVolume { get; set; }

        [JsonProperty("avgTotalVolume")]
        public long AvgTotalVolume { get; set; }

        [JsonProperty("iexBidPrice")]
        public object IexBidPrice { get; set; }

        [JsonProperty("iexBidSize")]
        public object IexBidSize { get; set; }

        [JsonProperty("iexAskPrice")]
        public object IexAskPrice { get; set; }

        [JsonProperty("iexAskSize")]
        public object IexAskSize { get; set; }

        [JsonProperty("marketCap")]
        public long MarketCap { get; set; }

        [JsonProperty("peRatio")]
        public double PeRatio { get; set; }

        [JsonProperty("week52High")]
        public double Week52High { get; set; }

        [JsonProperty("week52Low")]
        public double Week52Low { get; set; }

        [JsonProperty("ytdChange")]
        public double YtdChange { get; set; }
    }

    public partial class Stocks
    {
        public static Stocks FromJson(string json) => JsonConvert.DeserializeObject<Stocks>(json, QuickType.ConverterStocks.Settings);
    }

    public static class SerializeStocks
    {
        public static string ToJson(this Stocks self) => JsonConvert.SerializeObject(self, QuickType.ConverterStocks.Settings);
    }

    internal static class ConverterStocks
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}