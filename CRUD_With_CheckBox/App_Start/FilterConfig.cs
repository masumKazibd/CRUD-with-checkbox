﻿using System.Web;
using System.Web.Mvc;

namespace CRUD_With_CheckBox
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
