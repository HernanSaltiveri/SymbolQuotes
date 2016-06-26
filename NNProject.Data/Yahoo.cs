using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NNProject.Data
{
    public class Wombat : IProvider
    {
        public string[] getCompanies(string filter) {
            //http://finance.yahoo.com/q?s=msft&ql=1
            
            return null; }
        public string[] getQuotes(string company) {
            //http://finance.yahoo.com/webservice/v1/symbols/COALINDIA.NS/quote?format=json&view=detail

            //string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20%3D%20%22"
            //    + brand + "%22%20and%20startDate%20%3D%20%22"
            //    + fromDate + "%22%20and%20endDate%20%3D%20%22"
            //    + toDate + "%22&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";

            string url = "http://finance.yahoo.com/webservice/v1/symbols/TKR/quote?format=json&view=detail";

            // get and parse XML
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string xml = wc.DownloadString(url);
            XDocument doc = XDocument.Parse(xml);

            return null; }
    }
}
