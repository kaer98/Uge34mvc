using Microsoft.AspNetCore.Mvc;

namespace uge34mvc.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
