using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleProject.Model;

namespace SimpleProject.Pages
{
    public class IndexModel : PageModel
    {
        [ModelBinder]
        public UserModel User { get; set; }

        [TempData]
        public String Message { get; set; }

        public void OnGet()
        {

        }
        [HttpPost]
        [ActionName("simple")]
        public void OnPostSimple()
        {
            if (ModelState.IsValid)
            {
                Message = "Valid Simple";
            }
            else
            {
                Message = "Not valid Simple";
            }
        }

        [HttpPost]
        [ActionName("template")]
        public void OnPostTemplate()
        {
            if (ModelState.IsValid)
            {
                Message = "Valid Template";
            }
            else
            {
                Message = "Not valid Template";
            }
        }
    }
}
