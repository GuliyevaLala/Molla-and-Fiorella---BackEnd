using Microsoft.AspNetCore.Mvc;
using Molla_Backend.Models;
using System.Diagnostics;

namespace Molla_Backend.Controllers {
    public class HomeController : Controller {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}