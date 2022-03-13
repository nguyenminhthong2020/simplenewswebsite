using Microsoft.AspNetCore.Mvc;
using SimpleNewsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //List<Category> lst = Category.getAllCategory();
            //return View(lst);

            //var model = new ListCategoryViewModel();
            ViewData["list_category"] = Category.getAllCategory();
            ViewData["list_four_new_post"] = Post.getNewPostsByTime(4);
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["list_category"] = Category.getAllCategory();
            return View();
        }
    }
}
