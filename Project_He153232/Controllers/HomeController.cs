using Microsoft.AspNetCore.Mvc;

namespace Project_He153232.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
