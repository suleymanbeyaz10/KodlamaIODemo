using KodlamaIO.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes.EntityFramework
{
    public class KodlamaIOContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // kendi connection stringinizi yazınız.


            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KodlamaIO;Trusted_Connection=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
