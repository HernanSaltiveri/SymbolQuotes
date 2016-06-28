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
        IVendor vend;        

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
            Init();
        }
        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            string pvend = "NNProject.Data." + ConfigurationManager.AppSettings["Vendor"];
            AssemblyName assemblyName = AssemblyName.GetAssemblyName(HttpContext.Current.Server.MapPath("~\\Bin\\NNProject.Data.dll"));
            string typeAssemblyQualifiedName = string.Join(", ", pvend, assemblyName.FullName);
            Type ptype = Type.GetType(typeAssemblyQualifiedName);
            vend = (IVendor)Activator.CreateInstance(ptype);
        }
        #endregion


    }
}