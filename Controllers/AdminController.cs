using Microsoft.AspNetCore.Mvc;

namespace FitConnect.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
