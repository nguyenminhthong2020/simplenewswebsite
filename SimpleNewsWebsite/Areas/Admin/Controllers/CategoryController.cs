using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SimpleNewsWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimpleNewsWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public class CategoryValidation
        {
            public string catid
            {
                get;
                set;
            }

            // [A-Z]{3} [A-Z]{3}\s+[\d.,]+
            [Required(ErrorMessage = "Phải nhập tên danh mục")]
            [RegularExpression(@"\s*([A-Za-z0-9ÀÁÂÃÈÉÊẾÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéếêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂ ưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]\s*){5,}", ErrorMessage = "tên phải có ít nhất 5 ký tự")]
            [StringLength(50, MinimumLength = 5, ErrorMessage = "Chiều dài từ 5 - 50 ký tự")]
            [Display(Name = "Catname")]
            public string catname
            {
                get;
                set;
            }

            [Display(Name = "Catstatus")]
            public bool catstatus
            {
                get;
                set;
            }
        }

        //public IActionResult Category()
        //{
        //    if (TempData["form1"] != null)
        //    {
        //        ViewData["form1"] = TempData["form1"].ToString();
        //    }

        //    if (TempData["minhthong"] != null)
        //    {
        //        ViewData["minhthong"] = TempData["minhthong"].ToString();
        //    }

        //    if (TempData["result"] != null)
        //    {
        //        ViewData["result"] = TempData["result"].ToString();
        //    }

        //    if (TempData["isError"] != null)
        //    {
        //        ViewBag.isError = 1;
        //    }

        //    if (TempData["use"] != null)
        //    {
        //        ViewData["use"] = TempData["use"].ToString();
        //    }
        //    else
        //    {
        //        ViewData["use"] = "start";
        //    }

        //    if (TempData["errors"] != null)
        //    {
        //        var listErrorString = TempData["errors"].ToString();
        //        var listError = JsonSerializer.Deserialize<List<MyError>>(listErrorString);
        //        foreach (var item in listError)  //nhấn foreach + tab
        //        {
        //            ModelState.AddModelError(item.key, item.message);
        //        }
        //    }

        //    ViewData["list_category"] = SimpleNewsWebsite.Models.Category.getAllCategory();

        //    return View("Category", new CategoryValidation());
        //}

        public const int perPage = 5;

        //[HttpGet]
        public IActionResult Category()
        {
            ViewBag.PerPage = perPage;

            if (TempData["form1"] != null)
            {
                ViewData["form1"] = TempData["form1"].ToString();
            }

            if (TempData["minhthong"] != null)
            {
                ViewData["minhthong"] = TempData["minhthong"].ToString();
            }

            if (TempData["result"] != null)
            {
                ViewData["result"] = TempData["result"].ToString();
            }

            if (TempData["isError"] != null)
            {
                ViewBag.isError = 1;
            }

            if (TempData["use"] != null)
            {
                ViewData["use"] = TempData["use"].ToString();
            }
            else
            {
                ViewData["use"] = "start";
            }

            if (TempData["errors"] != null)
            {
                var listErrorString = TempData["errors"].ToString();
                var listError = JsonSerializer.Deserialize<List<MyError>>(listErrorString);
                foreach (var item in listError)  //nhấn foreach + tab
                {
                    ModelState.AddModelError(item.key, item.message);
                }
            }

            ViewData["list_category"] = SimpleNewsWebsite.Models.Category.getAllCategory();

            return View("Category", new CategoryValidation());
        }



        [HttpPost]
        public IActionResult Create(CategoryValidation categoryValidation)
        {
            if (ModelState.IsValid)
            {
                //ViewData["form1"] = $" {categoryValidation.catname} and {categoryValidation.catstatus}";

                string _username = HttpContext.Session.GetString("Username");
                int result = SimpleNewsWebsite.Models.Category.add(categoryValidation.catname, categoryValidation.catstatus, _username);

                TempData["result"] = result;
                TempData["use"] = "start";  // add, edit, delete
                //TempData["form1"] = $" {categoryValidation.catname} and {categoryValidation.catstatus}";
                return RedirectToAction("Category");
            }
            else
            {

                List<MyError> lst = new List<MyError>();

                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        var k = modelStateKey;
                        var m = error.ErrorMessage;
                        lst.Add(new MyError { key = k, message = m });
                    }
                }

                var lstString = JsonSerializer.Serialize(lst);

                TempData["errors"] = lstString;
                TempData["isError"] = "true";
                TempData["use"] = "add";
                return RedirectToAction("Category");
                //return View("Category", categoryValidation);
            }
        }


        [HttpPost]
        public IActionResult Edit(CategoryValidation categoryValidation)
        {
            if (ModelState.IsValid)
            {
                //ViewData["form1"] = $" {categoryValidation.catname} and {categoryValidation.catstatus}";
                SimpleNewsWebsite.Models.Category c = SimpleNewsWebsite.Models.Category.getCategory(categoryValidation.catid);
                int _status = categoryValidation.catstatus == true ? 1 : 0;
                if (c.CatName != categoryValidation.catname || c.CatStatus != _status)
                {
                    string _username = HttpContext.Session.GetString("Username");
                    int result = SimpleNewsWebsite.Models.Category.edit(categoryValidation.catid, categoryValidation.catname, categoryValidation.catstatus, _username);

                    TempData["result"] = result;
                }


                TempData["use"] = "start";  // add, edit, delete
                //TempData["form1"] = $"Edit {categoryValidation.catid}:{categoryValidation.catname} and {categoryValidation.catstatus}, result: {result}";
                return RedirectToAction("Category");
            }
            else
            {

                List<MyError> lst = new List<MyError>();

                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        var k = modelStateKey;
                        var m = error.ErrorMessage;
                        lst.Add(new MyError { key = k, message = m });
                    }
                }

                var lstString = JsonSerializer.Serialize(lst);

                TempData["errors"] = lstString;
                TempData["minhthong"] = "kỳ vậy nè";
                TempData["isError"] = "true";
                TempData["use"] = "edit";
                return RedirectToAction("Category");
                //return View("Category", categoryValidation);
            }
        }

        [HttpPost]
        public IActionResult Delete(CategoryValidation categoryValidation)
        {
            if (ModelState.IsValid)
            {
                //ViewData["form1"] = $" {categoryValidation.catname} and {categoryValidation.catstatus}";

                string _username = HttpContext.Session.GetString("Username");
                int result = SimpleNewsWebsite.Models.Category.delete(categoryValidation.catid);

                TempData["result"] = result;
                TempData["use"] = "start";  // add, edit, delete
                //TempData["form1"] = $"Delete {categoryValidation.catid}:{categoryValidation.catname} and {categoryValidation.catstatus}, result: {result}";
                return RedirectToAction("Category");
            }
            else
            {

                List<MyError> lst = new List<MyError>();

                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        var k = modelStateKey;
                        var m = error.ErrorMessage;
                        lst.Add(new MyError { key = k, message = m });
                    }
                }

                var lstString = JsonSerializer.Serialize(lst);

                TempData["errors"] = lstString;
                TempData["isError"] = "true";
                TempData["use"] = "delete";
                return RedirectToAction("Category");
                //return View("Category", categoryValidation);
            }
        }
    }
}
