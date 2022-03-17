using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleNewsWebsite.Areas.Admin.Models;
using SimpleNewsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimpleNewsWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        /// <summary>
        /// use class UserValidation for validating form login
        /// </summary>
        public class UserValidation
        {
            [Required(ErrorMessage = "Phải có username")]
            //[MinLength(3)]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Chiều dài từ 3 - 50 ký tự")]
            [Display(Name = "Username")]
            public string username
            {
                get;
                set;
            }

            [Required(ErrorMessage = "Thiếu password")]
            [MinLength(3, ErrorMessage = "Chiều dài phải >=3 ký tự")]
            [Display(Name = "Password")]
            public string password
            {
                get;
                set;
            }
        }


        public IActionResult Login()
        {
            return View("Login", new UserValidation());
        }

        [HttpPost]
        public IActionResult Login(UserValidation userValidation) // tham số truyền vào phải = name của các phần trong Form
        {
            if (ModelState.IsValid)
            {
                UserAuth u = UserAuth.validate(userValidation.username, userValidation.password);
                if (u != null)
                {
                    HttpContext.Session.SetString("Check", u.Check);
                    HttpContext.Session.SetString("Role", u.Role.ToString());
                    HttpContext.Session.SetString("Username", u.Username);
                    // tham khảo (hay)
                    // https://learningprogramming.net/net/asp-net-core-mvc/login-form-with-session-in-asp-net-core-mvc/

                    UserInfo.Username = userValidation.username;
                    UserInfo.Password = userValidation.password;
                    UserInfo.Check = true;
                    ViewData["usernamepassword"] = $"This is {userValidation.username} and {userValidation.password}";
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    UserInfo.Check = false;
                    ViewBag.message = "Nhập sai ít nhất email hoặc password";
                    return View("Login");
                }
            }
            else
            {
                UserInfo.Check = false;
                return View("Login", userValidation);
            }
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
