﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IdentitySolution.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> Register()
        {

            return View();
        }
    }
}