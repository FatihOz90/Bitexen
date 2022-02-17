using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static ClassOrderbook;
using static DataMarketList;

namespace Bitexen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static String QURL = "https://www.bitexen.com";
        private static IStockRestApi stockGet = new StockRestApi(QURL);

        public Dictionary<string, MarketData> DicMarketInfo = new Dictionary<string, MarketData>();
        public Dictionary<string, OrderBooksData> DicOrderboxInfo = new Dictionary<string, OrderBooksData>();


        readonly DataTable dtDGV_ALIS = new DataTable();
        readonly DataTable dtDGV_SATIS = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            MarketLoad();
            //new Thread(new ThreadStart(OrderboxLoad))
            //{
            //    IsBackground = true
            //}.Start();

            //Render
            DGV_ALIS.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(DGV_ALIS, true, null);
            DGV_SATIS.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(DGV_SATIS, true, null);


            dtDGV_ALIS.Columns.Add("Price");
            dtDGV_ALIS.Columns.Add("Quantity");
            dtDGV_ALIS.Columns.Add("Total", typeof(decimal));

            dtDGV_SATIS.Columns.Add("Price");
            dtDGV_SATIS.Columns.Add("Quantity");
            dtDGV_SATIS.Columns.Add("Total", typeof(decimal));
        }

        private void MarketLoad()
        {
            var marketinfo = stockGet.marketinfo();
            var ResultsupplyCoin = JsonConvert.DeserializeObject<MarketData>(marketinfo);
            if (ResultsupplyCoin.status == "success")
            {
                for (int i = 0; i < ResultsupplyCoin.data.markets.Count; i++)
                {
                    DicMarketInfo.Add(ResultsupplyCoin.data.markets[i].market_code, ResultsupplyCoin);
                }

                foreach (var item in DicMarketInfo)
                {
                    ListViewItem Ivi = new ListViewItem
                    {
                        //ListView e ekleme yapmak için itemından nesne oluşturup ona ekliyoruz
                        Name = item.Key,     //text ilk kolon
                        Text = item.Key     //text ilk kolon
                    };
                    listView1.Items.Add(Ivi);

                    //listView1.Items.Add(item.Key);
                }

            }
        }

        private void OrderboxLoad(string symbol)
        {
            //foreach (var item in DicMarketInfo.Keys)
            //{
            DicOrderboxInfo.Clear();
            var orderbooksinfo = stockGet.orderBook(symbol);
            var ResultsupplyCoin = JsonConvert.DeserializeObject<OrderBooksData>(orderbooksinfo);
            if (ResultsupplyCoin.status == "success")
            {
                DicOrderboxInfo.Add(ResultsupplyCoin.data.market_code, ResultsupplyCoin);
            }
            //}
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int itemIndex = 0; itemIndex < listView1.Items.Count; itemIndex++)
            {
                ListViewItem item = listView1.Items[itemIndex];
                Rectangle itemRect = item.GetBounds(ItemBoundsPortion.Label);
                if (itemRect.Contains(e.Location))
                {
                    OrderboxLoad(item.Text);
                    DGVordersbooks(item.Text);
                    break;
                }
            }
        }

        private void DGVordersbooks(string Symbol)
        {
            try
            {

                dtDGV_ALIS.Rows.Clear();
                dtDGV_SATIS.Rows.Clear();

                var symb = DicOrderboxInfo[Symbol];

                foreach (var oItem in symb.data.Buyers)
                    dtDGV_ALIS.Rows.Add(new object[] { oItem.orders_price, oItem.orders_total_amount, Convert.ToDecimal(oItem.orders_price) * Convert.ToDecimal(oItem.orders_total_amount) });

                DGV_ALIS.DataSource = dtDGV_ALIS;

                foreach (var oItem in symb.data.Sellers)
                    dtDGV_SATIS.Rows.Add(new object[] { oItem.orders_price, oItem.orders_total_amount, Convert.ToDecimal(oItem.orders_price) * Convert.ToDecimal(oItem.orders_total_amount) });

                DGV_SATIS.DataSource = dtDGV_SATIS;

                HesaplamaYap();
            }
            catch (Exception) { }
        }

        private void HesaplamaYap()
        {
            decimal totalAlis = 0m, totalSatis = 0m;
            foreach (DataRow row in dtDGV_ALIS.Rows)
            {
                decimal Price = Convert.ToDecimal(row[0]);
                decimal Quantity = Convert.ToDecimal(row[1]);
                decimal Total = Price * Quantity;
                totalAlis += Total;
                row[2] = String.Format("{0:0.00}", Total);
            }
            lblAlis.Text = Convert.ToString(totalAlis + " / " + dtDGV_ALIS.Rows.Count + " Defter Kaydı");

            foreach (DataRow row in dtDGV_SATIS.Rows)
            {
                decimal Price = Convert.ToDecimal(row[0]);
                decimal Quantity = Convert.ToDecimal(row[1]);
                decimal Total = Price * Quantity;
                totalSatis += Total;
                row[2] = String.Format("{0:0.00}", Total);
            }
            lblSatis.Text = Convert.ToString(totalSatis + " / " + dtDGV_SATIS.Rows.Count + " Defter Kaydı");
        }

    }
}