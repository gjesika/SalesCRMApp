using Microsoft.AspNetCore.Mvc;

namespace SalesCRMApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
