using Microsoft.AspNetCore.Mvc;

namespace Project_He153232.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
