// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var currencyConverter = CurrencyConverter.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CurrencyConverter
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }
    }

    public partial class CurrencyConverter
    {
        public static CurrencyConverter FromJson(string json) => JsonConvert.DeserializeObject<CurrencyConverter>(json, QuickType.Converter.Settings);
    }

    public static class SerializeCurrency
    {
        public static string ToJson(this CurrencyConverter self)
        {
            return JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
        }
    }

    internal static class ConverterCurrency
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
