using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NNProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        /// <summary>
        /// Get Json Result
        /// </summary>
        public JsonResult getQuote(string Symbol) 
        {
            var jres = new JsonResult();
            return jres;
        }
    }
}
