﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string ffff = "fdgdfgdfgdfgdfgdfg";
            string ffff1 = "fdgdfgdfgdfgdfgdfg1";
            string ffff2 = "fdgdfgdfgdfgdfgdfg2";
            string ffff3 = "fdgdfgdfgdfgdfgdfg3";
            string ffff4 = "fdgdfgdfgdfgdfgdfg4";
            string ffff5 = "fdgdfgdfgdfgdfgdfg5";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
