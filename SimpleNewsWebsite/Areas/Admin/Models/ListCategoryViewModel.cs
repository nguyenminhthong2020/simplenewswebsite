using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleNewsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Models
{
    public class ListCategoryViewModel
    {
        public string ListCategory { get; set; }
        //public List<SelectListItem> Categories { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "Sport", Text = "Sport" },
        //    new SelectListItem { Value = "Education", Text = "Education" },
        //    new SelectListItem { Value = "Science", Text = "Science"  },
        //};
        public List<SelectListItem> Categories { get; } = Category.getAllCategory()
                                                                   .Select(i => new SelectListItem { Value = i.CatName, Text = i.CatName })
                                                                   .ToList();
    }
}
