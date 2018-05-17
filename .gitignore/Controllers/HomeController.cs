﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lewa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This page describes who we are, what we do and what we are about. So enjoy!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch with us, we love you.";

            return View();
        }
    }
}