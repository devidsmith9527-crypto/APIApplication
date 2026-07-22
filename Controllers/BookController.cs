using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIApplication.Models;

namespace APIApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private static List<Book> _books() => new List<Book>
        {
            new Book().BindBook(1, "The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10)),
            new Book().BindBook(2, "To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11)),
            new Book().BindBook(3, "1984", "George Orwell", new DateTime(1949, 6, 8)),
            new Book().BindBook(4, "Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28)),
        };            

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_books());
        }
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _books().FirstOrDefault(b => b.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }

}