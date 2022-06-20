using Microsoft.AspNetCore.Mvc;

namespace CoreArea.Areas.Calendar.Controllers
{
    public class HomeController : Controller
    {
        [Area("Calendar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
