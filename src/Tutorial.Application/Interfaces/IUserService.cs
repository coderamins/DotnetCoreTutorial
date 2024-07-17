using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
