using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Application.Interfaces;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository= userRepository;
        }
        public async Task<User> Authenticate(string username, string password)
        {
            var user=await _userRepository.GetUserByUserName(username);
            if (user == null || !VerifyPasswordHash(password, user.PasswordHash)){
                return null;
            }

            return user;
        }

        private bool VerifyPasswordHash(string password, string passwordHash)
        {
            // Implement password hashing/verification logic (e.g., using BCrypt)
            // Replace with your chosen password hashing method
            return password == passwordHash; // Placeholder for demonstration
        }
    }
}
