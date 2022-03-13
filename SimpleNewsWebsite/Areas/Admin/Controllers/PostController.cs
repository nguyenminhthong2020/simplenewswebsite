using Microsoft.AspNetCore.Http;
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
            //if (UserInfo.Check == true)
            //if (HttpContext.Session.GetString("Check") == "true")
            //{
            //    ViewData["usernamepassword"] = $"after loggin, username: {UserInfo.Username}, pass: {UserInfo.Password}";
            //    var model = new ListCategoryViewModel();
            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Home", new { area = "Admin" });
            //}
            ViewData["usernamepassword"] = $"after loggin, username: {UserInfo.Username}, pass: {UserInfo.Password}";
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
