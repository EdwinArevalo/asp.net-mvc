using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana9.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public string Default()
        {
            return "This is my <b>default</b> action...";
        }

        public ActionResult Welcome(string name, int numTimes = 5)
        {
            ViewBag.Message = "Hello "+ name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

        public string WelcomeTwo(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + " ID: " + ID);
        }
    }
}