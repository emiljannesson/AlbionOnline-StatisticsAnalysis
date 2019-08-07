﻿using System;
using System.Windows;
using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    //public class MarketOrder
    //{
    //    public ulong Id { get; set; }
    //    public string ItemTypeId { get; set; }
    //    public ushort LocationId { get; set; }
    //    public byte QualityLevel { get; set; }
    //    public byte EnchantmentLevel { get; set; }
    //    public ulong UnitPriceSilver { get; set; }
    //    public uint Amount { get; set; }
    //    public string AuctionType { get; set; }
    //    public DateTime Expires { get; set; }

    //    [NotMapped]
    //    public string ItemGroupTypeId { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Id}{Amount}";
    //    }
    //}

    public class MarketResponse
    {
        [JsonProperty(PropertyName = "item_id")]
        public string ItemTypeId { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "quality")]
        public int QualityLevel { get; set; }

        [JsonProperty(PropertyName = "sell_price_min")]
        public ulong SellPriceMin { get; set; }

        [JsonProperty(PropertyName = "sell_price_min_date")]
        public DateTime SellPriceMinDate { get; set; }

        [JsonProperty(PropertyName = "sell_price_max")]
        public ulong SellPriceMax { get; set; }

        [JsonProperty(PropertyName = "sell_price_max_date")]
        public DateTime SellPriceMaxDate { get; set; }

        [JsonProperty(PropertyName = "buy_price_min")]
        public ulong BuyPriceMin { get; set; }

        [JsonProperty(PropertyName = "buy_price_min_date")]
        public DateTime BuyPriceMinDate { get; set; }

        [JsonProperty(PropertyName = "buy_price_max")]
        public ulong BuyPriceMax { get; set; }

        [JsonProperty(PropertyName = "buy_price_max_date")]
        public DateTime BuyPriceMaxDate { get; set; }
    }

    public class MarketResponseTotal
    {
        [JsonProperty(PropertyName = "item_id")]
        public string ItemTypeId { get; set; }

        [JsonProperty(PropertyName = "city")]
        public Location City { get; set; }

        [JsonProperty(PropertyName = "quality")]
        public byte QualityLevel { get; set; }

        [JsonProperty(PropertyName = "sell_price_min")]
        public ulong SellPriceMin { get; set; }

        [JsonProperty(PropertyName = "sell_price_min_date")]
        public DateTime SellPriceMinDate { get; set; }

        [JsonProperty(PropertyName = "sell_price_max")]
        public ulong SellPriceMax { get; set; }

        [JsonProperty(PropertyName = "sell_price_max_date")]
        public DateTime SellPriceMaxDate { get; set; }

        [JsonProperty(PropertyName = "buy_price_min")]
        public ulong BuyPriceMin { get; set; }

        [JsonProperty(PropertyName = "buy_price_min_date")]
        public DateTime BuyPriceMinDate { get; set; }

        [JsonProperty(PropertyName = "buy_price_max")]
        public ulong BuyPriceMax { get; set; }

        [JsonProperty(PropertyName = "buy_price_max_date")]
        public DateTime BuyPriceMaxDate { get; set; }

        public bool BestSellMinPrice { get; set; }
        public bool BestSellMaxPrice { get; set; }
        public bool BestBuyMinPrice { get; set; }
        public bool BestBuyMaxPrice { get; set; }
    }

    public class MarketCurrentPricesItem
    {

        public MarketCurrentPricesItem(MarketResponseTotal marketResponseTotal)
        {
            ItemTypeId = marketResponseTotal.ItemTypeId;
            City = marketResponseTotal.City;
            QualityLevel = marketResponseTotal.QualityLevel;
            SellPriceMin = marketResponseTotal.SellPriceMin;
            SellPriceMinDate = marketResponseTotal.SellPriceMinDate;
            SellPriceMax = marketResponseTotal.SellPriceMax;
            SellPriceMaxDate = marketResponseTotal.SellPriceMaxDate;
            BuyPriceMin = marketResponseTotal.BuyPriceMin;
            BuyPriceMinDate = marketResponseTotal.BuyPriceMinDate;
            BuyPriceMax = marketResponseTotal.BuyPriceMax;
            BuyPriceMaxDate = marketResponseTotal.BuyPriceMaxDate;
            BestSellMinPrice = marketResponseTotal.BestSellMinPrice;
            BestSellMaxPrice = marketResponseTotal.BestSellMaxPrice;
            BestBuyMinPrice = marketResponseTotal.BestBuyMinPrice;
            BestBuyMaxPrice = marketResponseTotal.BestBuyMaxPrice;
        }

        public string ItemTypeId { get; set; }
        public Location City { get; set; }
        public byte QualityLevel { get; set; }
        public ulong SellPriceMin { get; set; }
        public DateTime SellPriceMinDate { get; set; }
        public ulong SellPriceMax { get; set; }
        public DateTime SellPriceMaxDate { get; set; }
        public ulong BuyPriceMin { get; set; }
        public DateTime BuyPriceMinDate { get; set; }
        public ulong BuyPriceMax { get; set; }
        public DateTime BuyPriceMaxDate { get; set; }

        public bool BestSellMinPrice { get; set; }
        public bool BestSellMaxPrice { get; set; }
        public bool BestBuyMinPrice { get; set; }
        public bool BestBuyMaxPrice { get; set; }

        public Style CityStyle {
            get {
                switch (City)
                {
                    case Location.Caerleon:
                        return Application.Current.FindResource("CaerleonStyle") as Style;
                    case Location.Thetford:
                        return Application.Current.FindResource("ThetfordStyle") as Style;
                    case Location.Bridgewatch:
                        return Application.Current.FindResource("BridgewatchStyle") as Style;
                    case Location.Martlock:
                        return Application.Current.FindResource("MartlockStyle") as Style;
                    case Location.Lymhurst:
                        return Application.Current.FindResource("LymhurstStyle") as Style;
                    case Location.FortSterling:
                        return Application.Current.FindResource("FortSterlingStyle") as Style;
                    default:
                        return Application.Current.FindResource("DefaultCityStyle") as Style;
                }
            }
        }

    }
}