﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Registration()

        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        
    }
}