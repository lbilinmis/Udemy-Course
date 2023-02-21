using Course.WebUI.Models;
using Course.WebUI.Repository;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace Course.WebUI.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {

            return View();
        }
        public IActionResult Apply()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                RepositoryData.AddStudent(student);
                return View("Thanks", student);

            }
            return View(student);
        }

        public IActionResult Thanks()
        {
            return View();
        }


        public IActionResult StudentList()
        {
            var list = RepositoryData.Students.Where(x => x.Confirm == true).ToList();
            return View(list);
        }
    }
}
