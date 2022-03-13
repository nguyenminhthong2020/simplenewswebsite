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
    public class TestController : ControllerBase
    {
        //// GET: api/<TestController>
        //[HttpGet]
        //public dynamic Get()
        //{
        //    return new { Name = "John", LastName = "Smith", Age = 42 };
        //}

        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "nguyễn", "minh", "thông" };
        }
    }
}
