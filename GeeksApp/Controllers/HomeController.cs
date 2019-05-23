using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeeksApp.Models;
using GeeksConfiguration;

namespace GeeksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGeekConfigManager _configuration;

        public HomeController(IGeekConfigManager configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            string strEmail = this._configuration.EmailID;
            string strAccountKey = this._configuration.AccountKey;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
