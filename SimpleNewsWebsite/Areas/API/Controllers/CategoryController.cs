using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET api/<CategoryController>/name
        [HttpGet("{name}")]
        public string Get(string name)
        {
            string result = SimpleNewsWebsite.Models.Category.checkCategoryExist(name);
            return result;
        }
    }
}
