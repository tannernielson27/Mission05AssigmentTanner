using Microsoft.AspNetCore.Mvc;

namespace Mission05AssigmentTanner.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Shows the homepage
        }

        public IActionResult Calculator()
        {
            return View(); //Shows calculator view
        }

    }
}
