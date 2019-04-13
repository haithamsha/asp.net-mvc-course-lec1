using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc_lec2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Search(string name)
        {
            string result = Server.HtmlEncode(name);
            return result.ToString();
        }

        
    }
}