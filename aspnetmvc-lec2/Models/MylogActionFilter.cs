using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace aspnetmvc_lec2.Models
{
    public class MylogActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            log("OnActionExecuting", filterContext.RouteData);
        }


        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            log("OnActionExecuting", filterContext.RouteData);
        }




        public void log(string methodName, RouteData routeData)
        {
            var conterollerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];

            var message = $"{methodName} Controller: {conterollerName} Action: {actionName}";

            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}