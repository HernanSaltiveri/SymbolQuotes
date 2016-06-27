using NNProject.Data.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public class Wombat : IVendor
    {
        //public string[] getCompanies(string filter) { return null; }
        //public string[] getQuotes(string company) { return null; }
        public List<Stock> getStocks(string filter) { return null; }
        public StockQuote getQuotes(string company) { return null; }
        
    }
}
