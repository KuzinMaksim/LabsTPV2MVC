using LabsTPV2._3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTPV2._3.Controllers
{
    
    public class CntHomeController : Controller
    {
        private readonly ILogger<CntHomeController> _logger;

        public CntHomeController(ILogger<CntHomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.Uvar = RouteData.Values["uvar"] == null ? "Пользовательская переменная не задана" : RouteData.Values["uvar"];
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
