using CoffeeShop.Models;
using CoffeeShopReg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public static List<CoffeeShop.Models.Products> ProductList = new List<CoffeeShop.Models.Products>();
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
        public IActionResult Summary( string firstName, string lastName, string email, string password, string coffee, string ageRange )
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;
            ViewData["email"] = email;
            ViewData["password"] = password;
            ViewData["coffee"] = coffee;
            ViewData["ageRange"] = ageRange;
            return View();
        }
        public IActionResult Products()
        {
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