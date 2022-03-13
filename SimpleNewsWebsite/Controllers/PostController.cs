using Microsoft.AspNetCore.Mvc;
using SimpleNewsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Controllers
{
    public class PostController : Controller
    {
        public IActionResult List()
        {
            ViewData["list_category"] = Category.getAllCategory();
            return View();
        }
        public IActionResult Detail()
        {
            ViewData["list_category"] = Category.getAllCategory();
            return View();
        }

        //[Route("Post/Detail/{id:int}")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
            ViewData["list_category"] = Category.getAllCategory();
            ViewData["post_detail"] = Post.getPostById(id);

            //ViewData["list_category"] = Category.getAllCategory();
            //string imageURL = "~/img/h" + id + ".jpg";
            //ViewData["link"] = imageURL;

            return View();
        }
    }
}
