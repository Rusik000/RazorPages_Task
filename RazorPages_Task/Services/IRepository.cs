using RazorPages_Task.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_Task.Services
{
    public interface IRepository
    {
        void Add(Person person);

        void Delete(int id);
       void Update(Person person);
        Person Get(int id);
        IEnumerable<Person> GetAll();
    }
}
