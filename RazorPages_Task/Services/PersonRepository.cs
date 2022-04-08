using RazorPages_Task.DATA;
using RazorPages_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_Task.Services
{
    public class PersonRepository : IRepository
    {

        private readonly PersonDbContext _context;

        public PersonRepository(PersonDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public void Add(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            foreach (var item in _context.Persons)
            {
                if (item.Id == id)
                {
                    _context.Persons.Remove(item);
                }
            }
            _context.SaveChanges();
        }

        public void Update(Person person)
        {
            foreach (var item in _context.Persons)
            {
                if (item.Id == person.Id)
                {
                    item.Name = person.Name;
                    item.Surname = person.Surname;
                    item.Address = person.Address;
                    item.Age = person.Age;
                    item.Salary = person.Salary;
                }

            }
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            foreach (var item in _context.Persons)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;

        }


    }
}
