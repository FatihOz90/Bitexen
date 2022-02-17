using System.Collections.Generic;


    public class DataMarketList
    {

        public class trigger_order
        {
            public bool L { get; set; }
            public bool M { get; set; }
        }
        public class MarketInfo
        {
            public string market_code { get; set; }
            public string url_symbol { get; set; }
            public string base_currency { get; set; }
            public string counter_currency { get; set; }
            public string minimum_order_amount { get; set; }
            public string maximum_order_amount { get; set; }
            public decimal base_currency_decimal { get; set; }
            public decimal counter_currency_decimal { get; set; }
            public decimal presentation_decimal { get; set; }
            public bool resell_market { get; set; }
            public string min_multiplier { get; set; }
            public string max_multiplier { get; set; }
            public string base_currency_name { get; set; }
            public string counter_currency_name { get; set; }
            public trigger_order trigger_Order { get; set; }
        }

        public class MarketData
        {
            public string status { get; set; }
            public dataMarketData data { get; set; }
        }
        public class dataMarketData
        {
            public List<MarketInfo> markets { get; set; }
        }
    }
