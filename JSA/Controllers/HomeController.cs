using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safe_Task_Analysis.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        protected Safe_Task_Analysis.Models.JSA_DataFunctions df = new Safe_Task_Analysis.Models.JSA_DataFunctions();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Tutorial()
        {
            return View();
        }

        public string isAdmin()
        {
            if (df.authAdmin())
                return "true";
            else
                return "false";
        }
    }
}
