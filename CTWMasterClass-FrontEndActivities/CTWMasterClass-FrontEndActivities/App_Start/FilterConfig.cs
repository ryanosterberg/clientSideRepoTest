﻿using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_FrontEndActivities
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
