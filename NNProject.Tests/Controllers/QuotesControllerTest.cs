using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NNProject.Web;
using NNProject.Web.Controllers;
using Ninject;
using NNProject.Data;
using Rhino.Mocks;
using Newtonsoft.Json.Linq;


namespace NNProject.Tests.Controllers
{
    [TestClass]
    public class QuotesControllerTest
    {

        [TestMethod]
        public void GetSymbols_Test()
        {
            //TO BE IMPLEMENTED
            //QuotesController controller = new QuotesController();
            //string rtn = controller.GetSymbols("");
            Assert.AreEqual("1", "1");
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetQuote_Test()
        {
            var mockConfig = MockRepository.GenerateMock<IConfig>();

            var controller = new QuotesController(mockConfig);
            controller.vend = new Yahoo();

            var rtnvalue = controller.GetQuote("AAPL");
            JObject jObject = JObject.Parse(rtnvalue);
            JToken jValue = jObject["LastPrice"];
            string value = jValue.ToString();


            Assert.AreEqual(value, "10");
        }
    }
}
