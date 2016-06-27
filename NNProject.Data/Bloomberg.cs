using NNProject.Data.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public class Bloomberg : IVendor
    {
        public List<Stock> getStocks(string filter) {
                var lst = new List<Stock>();
                lst.Add(new Stock() { Symbol = "AAPL" });
                lst.Add(new Stock() { Symbol = "MSFT" });
                lst.Add(new Stock() { Symbol = "AMEX" });
                return lst;
             }
        public StockQuote getQuotes(string company) { 
            
            return null; 
        
        }
    }
}
