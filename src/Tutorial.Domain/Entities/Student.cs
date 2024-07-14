using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class Student: BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public virtual ICollection<Course> Courses { get; set; }= new List<Course>();    
    }
}
