using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Application.Interfaces;
using Tutorial.Domain;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtSettings _jwtSettings;
        public TokenService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }
        public ClaimsPrincipal ValidateAccessToken(string accessToken)
        {
            throw new NotImplementedException();
        }

        public string GenerateAccessToken(User user)
        {
            var securityKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            //var credentials

            return null;
        }
    }
}
