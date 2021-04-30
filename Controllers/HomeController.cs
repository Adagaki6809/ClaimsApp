using ClaimsApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimsApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Policy = "AgeLimit")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return Content("For all ages");
        }
    }
}
