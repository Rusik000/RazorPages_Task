using Microsoft.EntityFrameworkCore;
using RazorPages_Task.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_Task.DATA
{
    public class PersonDbContext:DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }


    }
}
