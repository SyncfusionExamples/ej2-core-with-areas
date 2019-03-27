using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreArea.Areas.Grid.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreArea.Areas.Admin.Controllers
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