using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safe_Task_Analysis.Helpers
{
    public static class HtmlHelpers
    {
        public static String GetUserName(this HtmlHelper helper)
        {
            String s = HttpContext.Current.User.Identity.Name.ToString();

            if (s.IndexOf("\\") > 0)
                s = s.Substring(s.LastIndexOf("\\") + 1);

            return s;
        }

    }
}