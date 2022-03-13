using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleNewsWebsite.Areas.Admin.Models;
using SimpleNewsWebsite.Models;
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
            UserAuth u = UserAuth.validate(username, password);
            if (u != null)
            {
                HttpContext.Session.SetString("Check", u.Check);
                HttpContext.Session.SetString("Role", u.Role.ToString());
                // tham khảo (hay)
                // https://learningprogramming.net/net/asp-net-core-mvc/login-form-with-session-in-asp-net-core-mvc/

                UserInfo.Username = username;
                UserInfo.Password = password;
                UserInfo.Check = true;
                ViewData["usernamepassword"] = $"This is {username} and {password}";
                return RedirectToAction("Dashboard");
            }
            else
            {
                UserInfo.Check = false;
                return View();
            }
            //return View();
        }

        //[Route("logout")]
        //[HttpGet]
        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Remove("username");
        //    return RedirectToAction("Index");
        //}

        public IActionResult Dashboard()
        {
            //if (UserInfo.Check == true)
            //if (HttpContext.Session.GetString("Check") == "true")
            //{
            //    ViewData["usernamepassword"] = $"after loggin, username: {UserInfo.Username}, pass: {UserInfo.Password}";
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
            ViewData["usernamepassword"] = $"after loggin, username: {UserInfo.Username}, pass: {UserInfo.Password}";
            return View();
        }
    }
}
