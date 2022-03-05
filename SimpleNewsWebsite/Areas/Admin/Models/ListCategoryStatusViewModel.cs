using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleNewsWebsite.Areas.Admin.Models
{
    public class ListCategoryStatusViewModel
    {
        public string ListCategoryStatus { get; set; }
        public List<SelectListItem> Status { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Sport", Text = "Sport" },
            new SelectListItem { Value = "Education", Text = "Education" },
            new SelectListItem { Value = "Science", Text = "Science"  },
        };
    }
}
