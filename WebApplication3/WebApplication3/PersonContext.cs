using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3
{
    public class PersonContext:DbContext
    {
        public DbSet<Person>People { get; set; }
    }
}