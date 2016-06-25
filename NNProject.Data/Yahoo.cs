using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNProject.Data
{
    public class Wombat : IProvider
    {
        public string[] getCompanies(string filter) {
            //http://finance.yahoo.com/q?s=msft&ql=1
            
            return null; }
        public string[] getQuotes(string company) {
            //http://finance.yahoo.com/webservice/v1/symbols/COALINDIA.NS/quote?format=json&view=detail

            return null; }
    }
}
