using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartwareWebsite.Web.Models;

namespace SmartwareWebsite.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Consultancy()
        {
            return View();
        }

        public IActionResult SmartTutoring()
        {
            return View();
        }

        public IActionResult CloudComputing()
        {
            return View();
        }

        public IActionResult WebAppDevelopment()
        {
            return View();
        }

        public IActionResult MobileAppDevelopment()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Expertise()
        {
            return View();
        }

        public IActionResult AboutUs()
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
