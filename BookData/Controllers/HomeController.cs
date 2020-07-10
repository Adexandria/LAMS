using BookData.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {

        private readonly ILogin login;
        private readonly IBook book;
        private Details details;
        
        public HomeController(ILogin login,IBook book)
        {

            this.login = login;
             this.book = book;
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
                    return NotFound("Username not found");
                }
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database error");
            }
        }
        
        [HttpPost("{Admin}")]
        public IActionResult Post(Books books, string username, string password)
        {
            var admin = login.GetDetails(username, password);
            if (admin != null)
            {
                book.Add(books);
                book.Commit();
                return Created("Book created", books);
            }
            else
            {
                return NotFound("You are not an Admin");
            }
        }
    }
}
