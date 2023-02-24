using Course.FormWebUI.Data;
using Course.FormWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Course.FormWebUI.Controllers
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
            var list=Data.ProductRepository.Products.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            Data.ProductRepository.AddProduct(product);
            return RedirectToAction("Index");

        }
        public IActionResult Search(string q)
        {
            if (String.IsNullOrWhiteSpace(q))
            {
                return View();
            }

            var list = ProductRepository.Products.Where(x => x.Name.Contains(q)).ToList();
            return View("Index",list);
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