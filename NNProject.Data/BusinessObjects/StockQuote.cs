using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data.BusinessObjects
{
    public class StockQuote
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string LastPrice { get; set; }

        public string Change { get; set; }
        public string ChangePercent { get; set; }
        public string TimeStamp { get; set; }

        public string MSDate { get; set; }
        public string MarketCap { get; set; }
        public string Volume { get; set; }

        public string ChangeYTD { get; set; }
        public string ChangePercentageYTD { get; set; }
        public string High { get; set; }

        public string Low { get; set; }
        public string Open { get; set; }
    }
}
