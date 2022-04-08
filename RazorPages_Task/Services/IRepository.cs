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

        void Update(int id);
        Person Get(int id);
        IEnumerable<Person> GetAll();
    }
}
