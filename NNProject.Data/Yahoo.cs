using NNProject.Data.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NNProject.Data
{
    public class Yahoo : IVendor
    {
        public List<Stock> getStocks(string filter) {
            var lst = new List<Stock>();
            lst.Add(new Stock() { Symbol = "AAPL" });
            lst.Add(new Stock() { Symbol = "MSFT" });
            lst.Add(new Stock() { Symbol = "AMEX" });
            lst.Add(new Stock() { Symbol = "NYE" });
            return lst;
            //return null; 
        }
        public StockQuote getQuotes(string company) { 
            var  lst = new List<StockQuote>();
            lst.Add(new StockQuote() { Symbol = "AAPL", LastPrice = "10", Change = "0.05", ChangePercent = "10%", ChangePercentYTD = "10%", ChangeYTD = "0.1", High = "11", Low = "9", MarketCap = "200000", MSDate = DateTime.Now.ToString(), Name = "Apple Computers", Open = "9.5", TimeStamp = DateTime.Now.ToString(), Volume = "20000" });
            lst.Add(new StockQuote() { Symbol = "MSFT", LastPrice = "30", Change = "0.05", ChangePercent = "10%", ChangePercentYTD = "10%", ChangeYTD = "0.1", High = "11", Low = "9", MarketCap = "200000", MSDate = DateTime.Now.ToString(), Name = "Apple Computers", Open = "9.5", TimeStamp = DateTime.Now.ToString(), Volume = "20000" });
            lst.Add(new StockQuote() { Symbol = "AMEX", LastPrice = "20", Change = "0.05", ChangePercent = "10%", ChangePercentYTD = "10%", ChangeYTD = "0.1", High = "11", Low = "9", MarketCap = "200000", MSDate = DateTime.Now.ToString(), Name = "Apple Computers", Open = "9.5", TimeStamp = DateTime.Now.ToString(), Volume = "20000" });
            lst.Add(new StockQuote() { Symbol = "NYE", LastPrice = "50", Change = "0.05", ChangePercent = "10%", ChangePercentYTD = "10%", ChangeYTD = "0.1", High = "11", Low = "9", MarketCap = "200000", MSDate = DateTime.Now.ToString(), Name = "Apple Computers", Open = "9.5", TimeStamp = DateTime.Now.ToString(), Volume = "20000" });
            var result = lst.FirstOrDefault(s => s.Symbol == company);
            return result;
        
        }
        //public string[] getCompanies(string filter) {
        //    //http://finance.yahoo.com/q?s=msft&ql=1
            
        //    return null; }
        //public string[] getQuotes(string company) {
        //    //http://finance.yahoo.com/webservice/v1/symbols/COALINDIA.NS/quote?format=json&view=detail

        //    //string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%3D%20%22"
        //    //    + brand + "%22%20and%20startDate%20%3D%20%22"
        //    //    + fromDate + "%22%20and%20endDate%20%3D%20%22"
        //    //    + toDate + "%22&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

        //    string url = "http://finance.yahoo.com/webservice/v1/symbols/TKR/quote?format=json&view=detail";

        //    // get and parse XML
        //    WebClient wc = new WebClient();
        //    wc.Encoding = Encoding.UTF8;
        //    string xml = wc.DownloadString(url);
        //    XDocument doc = XDocument.Parse(xml);

        //    return null; }
    }
}
