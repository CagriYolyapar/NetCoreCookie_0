using Microsoft.AspNetCore.Mvc;
using NetCoreCookie_0.Models;
using System.Diagnostics;
using NetCoreCookie_0.ExtensionMethods;

namespace NetCoreCookie_0.Controllers
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
            string a = "Deneme";
            string deger = a.Sekillendir();
            
            

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