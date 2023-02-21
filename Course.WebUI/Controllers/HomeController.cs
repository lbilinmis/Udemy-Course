using Course.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Course.WebUI.Controllers
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
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "Tünaydın" : "Günaydın";
            ViewBag.UserName = "Mehmet";

            return View();
        }

        public IActionResult Privacy()
        {
            CourseVM course=new CourseVM()
            {
                Name="Asp.Net MVC",
                Description="46 Saatlik Eğitim",
                IsPublished=false
            }; 

            return View(course);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}