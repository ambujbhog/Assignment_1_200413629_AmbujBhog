﻿using System.Web;
using System.Web.Mvc;

namespace Assignment_1_200413629_AmbujBhog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
