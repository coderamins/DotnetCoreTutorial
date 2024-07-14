using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Domain.Entities
{
    public class Course:BaseEntity
    {
        public required string CourseName { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
