using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Task.Services;

namespace RazorPages_Task.Pages.Delete
{
    public class DeletePageModel : PageModel
    {
        private readonly IRepository _repository;

        public DeletePageModel(IRepository repository)
        {
            _repository = repository;
        }
        [BindProperty]
        public int id { get; set; }

        public IActionResult OnPost()
        {
            _repository.Delete(id);       
            return RedirectToPage("/Index");
        }
    }
}
