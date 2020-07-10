using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookData.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        private readonly ILogin login;
       
        private Details details;
        
        public HomeController(ILogin login)
        {

            this.login = login;
            
        }
        



        [HttpGet]
        public IActionResult Search(string username, string password)
        {
            try
            {
                var admin = login.GetDetails(username, password);
                if (admin != null)
                {
                    return Ok("Success");
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database error");
            }
        }
        
    }
}
