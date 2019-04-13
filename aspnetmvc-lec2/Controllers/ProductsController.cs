using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc_lec2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Search(string category, string name)
        {
            var result = $"{Server.HtmlEncode(category)} --- {Server.HtmlEncode(name)}"; ;
            return Content(result);
        }
    }
}