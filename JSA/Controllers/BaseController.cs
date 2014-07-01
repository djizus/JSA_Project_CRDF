using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;

namespace Safe_Task_Analysis.Controllers
{
    public class BaseController : Controller
    {
        protected int current_lang = 0;
        protected override void ExecuteCore()
        {
            var lang = Request.Params["lang"];
            if (lang != null)
            {
                if (lang != string.Empty)
                {
                    if (lang.ToLower() == "fra")
                        lang = "fr-CA";
                    else if (lang.ToLower() == "eng")
                        lang = "en-CA";
                    else
                        lang = "en-CA";
                }
                else
                {
                    var cookie = HttpContext.Request.Cookies["Safe_Task_Analysis.CurrentUICulture"];
                    lang = string.Empty;
                    if (cookie != null)
                        lang = cookie.Value;
                    else
                        lang = "en-CA";
                }
            }
            else
            {
                var cookie = HttpContext.Request.Cookies["Safe_Task_Analysis.CurrentUICulture"];
                lang = string.Empty;

                if (cookie != null)
                    lang = cookie.Value;
                else
                    lang = "en-CA";
            }
            if (lang == "fr-CA")
                current_lang = 1;
            else
                current_lang = 0;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);
            HttpCookie _cookie = new HttpCookie("Safe_Task_Analysis.CurrentUICulture", Thread.CurrentThread.CurrentUICulture.Name);
            _cookie.Expires = DateTime.Now.AddYears(1);
            HttpContext.Response.SetCookie(_cookie);
            base.ExecuteCore();
        }
    }
}