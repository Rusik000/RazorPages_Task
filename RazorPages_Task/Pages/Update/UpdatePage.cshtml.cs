using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Task.Entities;
using RazorPages_Task.Services;

namespace RazorPages_Task.Pages.Update
{
    public class UpdatePageModel : PageModel
    {
        private readonly IRepository _repository;

        public UpdatePageModel(IRepository repository)
        {
            _repository = repository;
        }
        [BindProperty]
        public Person Person { get; set; }

        public IActionResult OnPost()
        {
            _repository.Update(Person);
            return RedirectToPage("/Index");
        }
    }
}
