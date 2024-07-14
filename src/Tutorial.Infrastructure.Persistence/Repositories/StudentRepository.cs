using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Application.Interfaces;
using Tutorial.Domain.Entities;

namespace Tutorial.Infrastructure.Persistence.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
