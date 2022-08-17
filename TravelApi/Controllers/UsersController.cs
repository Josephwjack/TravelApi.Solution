// using System;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Authorization;

// using TravelApi.Models;



// namespace TravelApi.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class UsersController : ControllerBase
//     {
//       private TravelApiContext _db;

//       private IUserService _userService;

//       public UsersController(TravelApiContext db, IUserService userService)
//       {
//         _db = db;
//         _userService = userService;
//       }

      
//       [HttpPost("authenticate")]
//       public IActionResult Authenticate(AuthenticateRequest model)
//       {
//          var response = _userService.Authenticate(model);

//          if (response == null)
//          return BadRequest(new { message = "Username or password is incorrect" });

//          return Ok(response);
//       }

//       [Authorize] 
//       [HttpGet]
//       public IActionResult GetAll()
//       {
//         var users =  _userService.GetAll();
//         return Ok(users);
//       }
       
//     }

// }
