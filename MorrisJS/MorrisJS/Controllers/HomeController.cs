using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MorrisJS.Models;

namespace MorrisJS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstMode = new List<SimpleReportViewModel>();
            lstMode.Add(new SimpleReportViewModel { Year = "2008", Value = 20 });
            lstMode.Add(new SimpleReportViewModel { Year = "2009", Value = 10 });
            lstMode.Add(new SimpleReportViewModel { Year = "2010", Value = 5 });
            lstMode.Add(new SimpleReportViewModel { Year = "2011", Value = 5 });
            lstMode.Add(new SimpleReportViewModel { Year = "2012", Value = 20 });
            return View(lstMode);
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
