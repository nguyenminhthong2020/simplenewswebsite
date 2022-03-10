using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password) // tham số truyền vào phải = name của các phần trong Form
        {
            ViewData["usernamepassword"] = $"This is {username} and {password}";
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
