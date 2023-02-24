using Course.CategoryWebUI.Repository;
using Course.MovieWebUI.Models;
using Course.MovieWebUI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Course.MovieWebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var list = Repository.MovieRepository.Movies;
            var catlist = CategoryRepository.Categories;

            CategoryMovieVM categoryMovieVM = new CategoryMovieVM();
            categoryMovieVM.Movies= list;
            categoryMovieVM.Categories= catlist;

            return PartialView(categoryMovieVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Movie movie=Repository.MovieRepository.GetMovieById(id);

            return View(movie);
        }


        public IActionResult List()
        {
            var list = Repository.MovieRepository.Movies;
            return View(list);
        }

        public IActionResult PartialMovies()
        {
            var list = Repository.MovieRepository.Movies;
            return PartialView(list);
        }
        public IActionResult PartialMenu()
        {
            return PartialView();
        }

        
    }
}
