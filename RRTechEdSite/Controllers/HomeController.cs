using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RRTechEdSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceWarning("Accessed Index at {0}", DateTime.Now);

            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceWarning("Accessed About at {0}", DateTime.Now);

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceWarning("Accessed Contacts at {0}", DateTime.Now);

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}