using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace SimpleNewsWebsite.Areas.API.Controllers
{
    public class CategoryExist
    {
        public string mycatname { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //public string Get(string name)
        //{
        //    string result = SimpleNewsWebsite.Models.Category.checkCategoryExist(name);
        //    return result;
        //}

        // POST api/<CategoryController>/check1
        [HttpPost]
        [Route("check1")]
        public string Check1([FromBody] CategoryExist categoryExist)
        {
            string result = SimpleNewsWebsite.Models.Category.checkCategoryExist(categoryExist.mycatname);
            return result;
            //return new JsonResult(object);
        }

        // POST api/<CategoryController>/check2
        [HttpPost]
        [Route("check2/{id}")]
        public string Check2(string id, [FromBody] CategoryExist categoryExist)
        {
            string result = SimpleNewsWebsite.Models.Category.checkCategoryExist2(id, categoryExist.mycatname);
            return result;
            //return new JsonResult(object);
        }

        // GET api/<CategoryController>/id
        // can use [Route("{id:int}")]
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return id;
        }


    }
}
