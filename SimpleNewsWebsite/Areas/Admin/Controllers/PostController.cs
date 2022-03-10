using Microsoft.AspNetCore.Mvc;
using SimpleNewsWebsite.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        public IActionResult ListPosts()
        {
            var model = new ListCategoryViewModel();
            return View(model);
        }

        public IActionResult EditPost()
        {
            var model = new ListCategoryViewModel();
            return View(model);
        }
    }
}
