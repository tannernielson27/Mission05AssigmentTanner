using Microsoft.AspNetCore.Mvc;

namespace Mission05AssigmentTanner.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

    }
}
