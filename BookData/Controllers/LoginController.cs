using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookData.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookData.Controllers
{
    [Route("api/[controller]")]
        [ApiController]
    public class LoginController : Controller
    {
        private readonly ISign_up sign;
        private readonly LinkGenerator gene;
        public LoginController(ISign_up sign, LinkGenerator gene)
        {
            this.sign = sign;
            this.gene = gene;
        }
        
       
        [HttpPost]
       public IActionResult Post(Signup signup)
        {
            var user = sign.GetAll(signup.UserName);
            if(user != null)
            {
                return BadRequest("Username is in use");
            }
            else
            {
                sign.Add(signup);
                sign.Commit();
                return Created("Username created", signup);
            }


        }
        [HttpGet("{user}")]
        public IActionResult Get(string username)
        {
            var user = sign.GetAll(username);
            if (user != null)
            {
                return Ok("Success");
            }
            else
            {
                return NotFound("Username doesn't exist ");
            }
        }
       
      
    }
}
