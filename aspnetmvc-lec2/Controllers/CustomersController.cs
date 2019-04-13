using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc_lec2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers


        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
        public string GetAllCustomers()
        {
            return @"<ul>
                        <li>Haitham</li>
                        <li>Weal</li>
                        <li>Ahmed</li>
                        <li>Loay</li>
                    </ul>";
        }
    }
}