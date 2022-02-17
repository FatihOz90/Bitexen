using System.Collections.Generic;


    public class ClassOrderbook
    {
        public class OrderBooksData
        {
            public string status { get; set; }
            public dataOrderBooks data { get; set; }
        }

        public class dataOrderBooks
        {
            public string market_code { get; set; }
            public ticker ticker { get; set; }
            public List<buyers> Buyers { get; set; }
            public List<sellers> Sellers { get; set; }
            public List<last_transactions> Last_Transactions { get; set; }
            public string timestamp { get; set; }
        }
        public class buyers
        {
            public string orders_total_amount { get; set; }
            public string orders_price { get; set; }
        }
        public class sellers
        {
            public string orders_total_amount { get; set; }
            public string orders_price { get; set; }
        }
        public class last_transactions
        {
            public string amount { get; set; }
            public string price { get; set; }
            public string time { get; set; }
            public string type { get; set; }
        }
        public class market
        {
            public string market_code { get; set; }
            public string base_currency_code { get; set; }
            public string counter_currency_code { get; set; }
        }
        public class ticker
        {
            public market market { get; set; }
            public string bid { get; set; }
            public string ask { get; set; }
            public string last_price { get; set; }
            public string last_size { get; set; }
            public string volume_24h { get; set; }
            public string change_24h { get; set; }
            public string low_24h { get; set; }
            public string high_24h { get; set; }
            public string avg_24h { get; set; }
            public string timestamp { get; set; }

        }
    }
