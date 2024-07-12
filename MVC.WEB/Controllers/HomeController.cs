using Microsoft.AspNetCore.Mvc;
using MVC.Web.Helpers;
using MVC.WEB.Models;
using System.Diagnostics;

namespace MVC.WEB.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RedirectToArticle()
        {
            var Title = "Asp.Net Core ile Gelen Yenilikler.C#_�";
            var id = 30;

            return RedirectToAction("Index", "Article", new { title = Title.MakeSeoFriendly(), id = id });
        }

        //[Route("home/product/{productId}")]
        //[Route("[controller]/[action]/{productId}")]
        //public IActionResult GetProduct(int productId)
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
