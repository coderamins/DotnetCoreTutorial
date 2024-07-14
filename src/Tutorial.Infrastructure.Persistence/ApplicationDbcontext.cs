using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Domain.Entities;

namespace Tutorial.Infrastructure.Persistence
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) :base(options)
        {            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }  
        public DbSet<StudentCourse> StudentsCourse { get; set;}

        
    }
}
