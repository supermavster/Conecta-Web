﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UB_Y4PT_2018.Controllers
{
    public class LegalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        public IActionResult TermsAndConditions()
        {
            return View();
        }

    }
}