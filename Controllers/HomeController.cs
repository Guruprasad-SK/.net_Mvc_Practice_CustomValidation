﻿using CustomValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomValidation.Models;

namespace CustomValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View();
        }
    }
}