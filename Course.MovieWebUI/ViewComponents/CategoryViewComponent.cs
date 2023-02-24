using Course.CategoryWebUI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Course.MovieWebUI.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}
