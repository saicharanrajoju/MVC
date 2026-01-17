using ecommerce_app.Controllers;
using ecommerce_app.Models;
using ecommerce_app.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_app
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly string key;
        private readonly IUsersService _UsersService;

        public AuthenticateService(IUsersService UsersService)
        {
            _UsersService = UsersService;
        }

        public AuthenticateService(string key)
        {
            this.key = key;
        }
        public string Authenticate(string email, string password)
        {
            User LoggedInUser = _UsersService.GetUserByEmail(email);
            string LoggedInUserName = LoggedInUser.FirstName + " " + LoggedInUser.LastName;
            if (LoggedInUser == null || LoggedInUser.Password != password) return null;
            // Token generation
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Role,LoggedInUser.Role),
                    new Claim(ClaimTypes.Email,LoggedInUser.Email),
                    new Claim(ClaimTypes.Name, LoggedInUserName)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptior);
            return tokenHandler.WriteToken(token);
        }
    }
}
