using Microsoft.AspNetCore.Mvc;

namespace HealthR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
