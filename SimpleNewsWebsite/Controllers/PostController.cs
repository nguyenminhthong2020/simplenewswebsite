using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }

        //[Route("Post/Detail/{id:int}")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
            string imageURL = "~/img/h" + id + ".jpg";
            ViewData["link"] = imageURL;
            return View();
        }
    }
}
