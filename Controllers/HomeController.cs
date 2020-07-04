using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dockertraining_jonatan_uscanga.Models;
using Microsoft.Extensions.Configuration;

namespace dockertraining_jonatan_uscanga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this._configuration = configuration;
        }


        public IActionResult Index()
        {
            ViewBag.EnvVar = _configuration.GetSection("AppSettings").GetSection("SubTitle").Value;
            ViewData["Title"] = _configuration.GetSection("AppSettings").GetSection("StoreName").Value;
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
