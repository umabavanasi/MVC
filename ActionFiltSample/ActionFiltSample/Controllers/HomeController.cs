using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace ActionFiltSample.Controllers
{
    public class HomeController : Controller, IActionFilter
    {
        // GET: Home
        public ActionResult Index()
        {
            Trace.WriteLine("Calling View from Controller" + DateTime.Now.ToString());
            return View();
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            //post processing logic
            Trace.WriteLine("Action has executed Post" + DateTime.Now.ToString());

        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            //preprocessing logic
            Trace.WriteLine("Action is executing Pre" + DateTime.Now.ToString());
        }
    }
}