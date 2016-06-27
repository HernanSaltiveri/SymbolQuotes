using NNProject.Data.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public interface IVendor
    {
        List<Stock> getStocks(string filter);
        StockQuote getQuotes(string company);
    }
}
