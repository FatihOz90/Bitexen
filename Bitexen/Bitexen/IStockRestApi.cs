using Bots_Hacim.Bitexen;
using System;

namespace Bitexen
{
    public interface IStockRestApi
    {
        String pairs();
        String marketinfo();
        String marketlist();
        String tickers();
        String ticker(String symbol);
        String orderBook(String symbol);
    }

    class StockRestApi : IStockRestApi
    {
        private String url_prex;

        public StockRestApi(String url_prex)
        {
            this.url_prex = url_prex;
        }

        public const String PAIRS_URL = "/api/v1/pairs";
        public const String MARKETINFO_URL = "/api/v1/market_info/";
        public const String MARKETLIST_URL = "/api/v1/marketlist";
        public const String TICKERS_URL = "/api/v1/tickers";
        public const String TICKER_URL = "/api/v1/ticker";
        public const String ORDERBOOK_URL = "/api/v1/order_book";

        public String pairs()
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";
            String result = httpUtil.requestHttpGet(url_prex, PAIRS_URL, param);
            return result;
        }

        public String marketinfo()
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";
            String result = httpUtil.requestHttpGet(url_prex, MARKETINFO_URL, param);
            return result;
        }

        public String marketlist()
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";
            String result = httpUtil.requestHttpGet(url_prex, MARKETLIST_URL, param);
            return result;
        }

        public String tickers()
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";
            String result = httpUtil.requestHttpGet(url_prex, TICKERS_URL, param);
            return result;
        }

        public String ticker(String symbol)
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";

            param += "/" + symbol;

            String result = httpUtil.requestHttpGet(url_prex, TICKER_URL + param, "");
            return result;
        }

        public String orderBook(String symbol)
        {
            HttpUtilManager httpUtil = HttpUtilManager.getInstance();
            String param = "";
            param += "/" + symbol;

            String result = httpUtil.requestHttpGet(url_prex, ORDERBOOK_URL + param, "/");
            return result;
        }
    }
}
