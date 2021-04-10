using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChartJS.Models;

namespace ChartJS.Controllers
{
    public class HomeController : Controller
    {
        private readonly Random rnd = new Random();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //list of moths
            var lstModel = new List<SimpleReportViewModel>
            {
                new SimpleReportViewModel
                {
                    DimensionOne = "January",
                    Quantity = rnd.Next(-100, 100)
                },
                new SimpleReportViewModel
                {
                    DimensionOne = "February",
                    Quantity = rnd.Next(-100, 100)
                },
                new SimpleReportViewModel
                {
                    DimensionOne = "March",
                    Quantity = rnd.Next(-100, 100)
                },
                new SimpleReportViewModel
                {
                    DimensionOne = "May",
                    Quantity = rnd.Next(-100, 100)
                },
                new SimpleReportViewModel
                {
                    DimensionOne = "June",
                    Quantity = rnd.Next(-100, 100)
                },
                new SimpleReportViewModel
                {
                    DimensionOne = "July",
                    Quantity = rnd.Next(-100, 100)
                }
            };
            _logger.LogInformation("Endpoint Index called!");
            return View(lstModel);
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
