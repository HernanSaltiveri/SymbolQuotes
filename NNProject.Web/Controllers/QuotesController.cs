using NNProject.Data.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;
using System.Web;
using System.Web.Script.Serialization;
using NNProject.Data;
using System.Configuration;
using System.Reflection;

namespace NNProject.Web
{
    public class QuotesController : ApiController
    {
        public IVendor vend;        

        [HttpGet]
        public string GetSymbols(string filter)
        {
            var lst = vend.getStocks(filter);
            var json = new JavaScriptSerializer().Serialize(lst);
            return json;
        }

        [HttpGet]
        public string GetQuote(string symbol)
        {
            var qts = vend.getQuotes(symbol);
            var json = new JavaScriptSerializer().Serialize(qts);
            return json;

        }


        #region Private
        /// <summary>
        /// 
        /// </summary>
        public QuotesController()
        {
            Init(null);
        }
        public QuotesController(IConfig conf)
        {
            Init(conf);
        }
        /// <summary>
        /// 
        /// </summary>
        private void Init(IConfig conf)
        {
            if(conf==null)
                conf = new Config();

            vend = conf.getVendor();
        }
        #endregion


    }
}