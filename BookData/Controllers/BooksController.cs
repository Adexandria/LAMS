using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookData.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBook book;
        public BooksController(IBook book)
        {
            this.book = book;
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
