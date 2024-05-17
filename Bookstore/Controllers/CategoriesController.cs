using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse()
        {
            return View();
        }
    }
}
