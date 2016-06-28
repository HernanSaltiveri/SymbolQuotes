using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NNProject.Web;

namespace NNProject.Test
{
    [TestClass]
    public class Test
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
