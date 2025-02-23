using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment1.DbContexts;
using EFCoreAssignment1.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreAssignment1.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() :base() 
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIDb ; Trusted_Connection  = true ;  TrustServerCertificate = true ");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
