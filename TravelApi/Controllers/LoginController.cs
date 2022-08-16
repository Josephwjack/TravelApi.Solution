// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using TravelApi.Models;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.Extensions.Configuration;


// namespace TravelApi.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class LoginController : ControllerBase
//     {
//         private IConfiguration _config;

        
//         public LoginController(IConfiguration config)
//         {
//               _config = config;
//         }

//         [AllowAnonymous]
//         [HttpPost]
//         public IActionResult Login([FromBody] UserLogin userLogin)
//         {
//           var user = Authenticate(userLogin);

//           if (user != null)
//           {
//             var token = Generate(user);
//             return Ok(token);
//           }
//           return NotFound("User not found");
//         }

//         private string Generate(User user)
//         {
//           throw new NotImplementedException();
//         }

//         private User Authenticate(UserLogin userLogin)
//         {
//           var currentUser = UserConstants.Users.FirstOrDefault(o => o.Username.ToLower() == userLogin.Username.ToLower() && o.Password == userLogin.Password);

//           if (currentUser != null)
//         }

       
//     }

// }