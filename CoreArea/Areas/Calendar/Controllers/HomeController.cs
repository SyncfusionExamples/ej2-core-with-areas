using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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