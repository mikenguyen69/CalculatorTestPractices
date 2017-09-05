using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View("Work");
        }

        public ActionResult CalculatorView(FormCollection collection)
        {
            //Calculator c = new Calculator();
            //c.Input1 = collection.
            return View("Work" );
        }
	}
}