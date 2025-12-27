using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }
        public DbSet<Project> Project {get; set;}
        public DbSet<Day> Day {get;set;} // links db to code

    }
}