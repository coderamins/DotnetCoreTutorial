using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Domain.Entities;

namespace Tutorial.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user);   
        ClaimsPrincipal ValidateAccessToken(string accessToken);

    }
}
