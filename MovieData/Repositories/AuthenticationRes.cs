using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Travel.Shared.ViewModels;

namespace MovieData.Repositories
{
    public class AuthenticationRes : IAuthentication
    {
        private readonly MovieAnimeContext _db;
        private Response res;
        private IConfiguration configuration;

        public AuthenticationRes(MovieAnimeContext db, IConfiguration _configuration)
        {
            _db = db;
            res = new Response();
            configuration = _configuration;

            //_authen = optionsMonitor.CurrentValue;
        }
        public Response Login(User model)
        {
            try
            {
                var user = _db.Users.SingleOrDefault(p => p.Email == model.Email && p.Password == model.Password);
                if (user == null)
                {
                    res.Success = false;
                    res.Message = "Sai tài khoản hoặc mật khẩu";
                }
                else
                {
                    res.Success = true;
                    res.Data = GenerateToken(user);
                }
                return res;
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message;
                return res;
            }
        
        }

        private string GenerateToken(User user)
        {
            var jwtTokenHandle = new JwtSecurityTokenHandler();
            var secretKeyBytes = Encoding.UTF8.GetBytes(configuration["SecretKey:Key"]);
            var tokeDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    //cần gì để show thì thêm vào
                    new Claim(ClaimTypes.Name, user.NameUser)

                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha512Signature)
            };
            var token = jwtTokenHandle.CreateToken(tokeDescription);
            return jwtTokenHandle.WriteToken(token);
        }
    }
}
