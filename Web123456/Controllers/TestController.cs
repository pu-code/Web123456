using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web123456.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HW1()
        {
            return View();
        }

        public ActionResult HW2()
        {
            return View();
        }

        public ActionResult HW3()
        {
            ViewBag.a = 1;
            ViewData["b"] = 2;

            return View();
        }
    }
}