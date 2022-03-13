using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Category(string catName, bool catStatus)
        {
            ViewData["form1"] = $"{catName} & {catStatus}";
            return View();
        }
    }
}
