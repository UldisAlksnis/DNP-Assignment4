using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DNP_Assignment3.Models;
using DNP_Assignment3.Data;

namespace DNP_Assignment3.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserLogin _userLogin;

        public UsersController(IUserLogin userLogin)
        {
            _userLogin = userLogin;
        }

        // GET: api/Users/5
        [HttpGet("{userName}")]
        public async Task<ActionResult<User>> GetUser(string userName)
        {

            try
            {
                User user = await _userLogin.ValidateUser(userName);
                if (user != null)
                {
                    return Ok(user);
                }
                    
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}
