using CoffeeShopReg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopReg.Controllers
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
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Summary( string firstName, string lastName, string email, string password )
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;
            ViewData["email"] = email;
            ViewData["password"] = password;

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