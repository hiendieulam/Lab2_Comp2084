﻿using System.Web;
using System.Web.Mvc;

namespace Lab1_HienLam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
