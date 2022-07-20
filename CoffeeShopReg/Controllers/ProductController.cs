using CoffeeShopReg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
