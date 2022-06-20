using CoreArea.Areas.Grid.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreArea.Areas.Grid.Controllers
{
    public class HomeController : Controller
    {
        [Area("Grid")]
        public IActionResult Index()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            return View();
        }
    }
}
