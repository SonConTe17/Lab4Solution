using Microsoft.AspNetCore.Mvc;

namespace DBFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Learners");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
