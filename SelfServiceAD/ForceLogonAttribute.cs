﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfServiceAD
{
    using System.Web.Routing;

    public class ForceLogonAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["Username"] == null)
            {
                filterContext.Result =
                    new RedirectToRouteResult(new RouteValueDictionary(new { action = "Index", controller = "Login" }));
            }
        }
    }
}