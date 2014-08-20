using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    /// <summary>
    /// default MVC mapping is /[Controller]/[ActionName]/[Parameters]
    /// </summary>

    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        // Alternative:  GET: /HelloWorld/Index

        //public string Index()
        //{
        //    return "This is <b> Default Action Method (Index) </b> that is called by Controller..";
        //}


        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/WelcomeAction/ 

        //public string WelcomeAction(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        public ActionResult WelcomeAction(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name + " from WelcomeAction";
            ViewBag.NumTimes = numTimes;

            return View();
        }
    } 
}
