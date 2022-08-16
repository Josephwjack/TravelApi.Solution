using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TravelApi.Models;
using TravelApi.Helpers;


namespace TravelApi.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        
    }

    public class UserService : IUserService
    {
      private TravelApiContext _users;

      private readonly Appsettings _appSettings;

      public UserService(IOptions<Appsettings> appSettings, TravelApiContext db)
      {
        _appSettings = appSettings.Value;
        _users = db;
      }

      public User Authenticate(string username, string password)
      {
        var user = _users.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

        if (user == null)
        {
          return null;
        }

        var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            

            return user;
      }

       public IEnumerable<User> GetAll()
        {
            List<User> u = new List<User> { };
            u = _users.Users.ToList();
            return u.Select(x =>
            {
              x.Password = null;
              return x;
            });
        }

      
    }
}