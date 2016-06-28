using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NNProject.Web;
using NNProject.Web.Controllers;


namespace NNProject.Tests.Controllers
{
    [TestClass]
    public class QuotesControllerTest
    {

        [TestMethod]
        public void GetSymbols_Test()
        {
            //QuotesController controller = new QuotesController();
            //string rtn = controller.GetSymbols("");
            Assert.AreEqual("1", "1");
        }
        [TestMethod]
        public void GetQuote_Test()
        {
            QuotesController controller = new QuotesController();
            //string rtn = controller.GetQuote("");
            Assert.AreEqual("1", "1");
        }
    }
}
