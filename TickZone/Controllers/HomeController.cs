using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TickZone.Models;

namespace TickZone.Controllers
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
            return View();
        }

       
       
    }
}