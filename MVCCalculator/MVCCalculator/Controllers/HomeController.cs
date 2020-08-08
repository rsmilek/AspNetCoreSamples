using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCalculator.Models;

namespace MVCCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Metodou GET se odesilaji hodnoty v URL adress napr.: https://localhost:44339/Home/Index?name=Radim
        public IActionResult Index(string name)
        {
            ViewBag.Name = name;
            var calculator = new Calculator(); 
            return View(calculator);
        }

        // Metodou POST se odesílají hodnoty z formuláře. Data se odešlou uvnitř HTTP požadavku na server.
        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                calculator.Calc();
            }
            return View(calculator);
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
