using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Task.Entities;
using RazorPages_Task.Services;

namespace RazorPages_Task.Pages.Add
{
    public class AddPageModel : PageModel
    {

        private readonly IRepository _repository;

        public AddPageModel(IRepository repository)
        {
            _repository = repository;
        }
        [BindProperty]
        public Person Person { get; set; }

        public IActionResult OnPost()
        {
            _repository.Add(Person);
            return RedirectToPage("/Index");
        }
    }
}
