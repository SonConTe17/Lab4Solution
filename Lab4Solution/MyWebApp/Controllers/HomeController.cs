using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Learner");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
