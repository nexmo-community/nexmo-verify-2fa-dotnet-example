﻿using System.Web;
using System.Web.Mvc;

namespace Nexmo2FADemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
