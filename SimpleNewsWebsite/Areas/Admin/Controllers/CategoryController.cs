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
            [Required(ErrorMessage = "Phải có tên danh mục")]
            // [A-Z]{3} [A-Z]{3}\s+[\d.,]+

            [RegularExpression(@"\s*([A-Za-z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂ ưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]\s*){5,}", ErrorMessage = "tên phải có ít nhất 5 ký tự")]
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

        public IActionResult Category()
        {
            if (TempData["form1"] != null)
            {
                ViewData["form1"] = TempData["form1"].ToString();
            }

            if (TempData["result"] != null)
            {
                ViewData["result"] = TempData["result"].ToString();
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
                TempData["form1"] = $" {categoryValidation.catname} and {categoryValidation.catstatus}";
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
                return RedirectToAction("Category");
                //return View("Category", categoryValidation);
            }
        }
    }
}
