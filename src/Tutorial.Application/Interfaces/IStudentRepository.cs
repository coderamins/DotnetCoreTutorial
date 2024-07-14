using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
    }
}
