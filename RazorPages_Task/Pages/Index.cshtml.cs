using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Task.DATA;
using RazorPages_Task.Entities;
using RazorPages_Task.Services;

namespace RazorPages_Task.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Person Person { get; set; }

        [BindProperty]
        public string CheckedId { get; set; }
        public List<Person> Persons { get; set; }

        //AllView +++
        public void OnGet()
        {
            Persons = _repository.GetAll().ToList();
        }


        //View one object
        public void OnPostView(string s)
        {
            int id = int.Parse(s);
            Persons = _repository
                .GetAll()
                .Where(p => p.Id ==id).ToList();
        }

        //Add
        public void OnPost()
        {
            _repository.Add(Person);          
        }

        //Delete
        public void OnPostDelete()
        {
            _repository.Delete(5);
        }

        //Update
        public void OnPostEdit(int id)
        {
            _repository.Update(id);
        }
    }
}
