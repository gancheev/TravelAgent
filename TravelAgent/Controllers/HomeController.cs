﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAgent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your asd description page.";
            ViewBag.Startup = "Zdrasti Bro";
            string Hello = "Hello string in viewbag";
            ViewBag.Hello = Hello;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // [HttpPost]
        public ActionResult kur()
        {
           // return View("About");
            return View();
        }
       
 
    }
}