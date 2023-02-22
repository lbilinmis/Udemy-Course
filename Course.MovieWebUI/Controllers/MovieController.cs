using Course.MovieWebUI.Models;
using Course.MovieWebUI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Course.MovieWebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var list = Repository.Repository.Movies;
            return PartialView(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Movie movie=Repository.Repository.GetMovieById(id);

            return View(movie);
        }


        public IActionResult List()
        {
            var list = Repository.Repository.Movies;
            return View(list);
        }

        public IActionResult PartialMovies()
        {
            var list = Repository.Repository.Movies;
            return PartialView(list);
        }
    }
}
