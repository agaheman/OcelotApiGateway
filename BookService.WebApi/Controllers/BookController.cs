using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BookService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> logger;
        private readonly List<Book> books;

        public BookController(ILogger<BookController> logger)
        {
            this.logger = logger;
            books = new List<Book>
            {
                new Book
                {
                    Name = "Clean Architecture",
                    Author = "Robert C. Martin",
                    PageCount = 1432,
                    Publisher = "Prentice Hall"
                },
                new Book
                {
                    Name = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Author = "Robert C. Martin",
                    PageCount = 434,
                    Publisher = "Prentice Hall"
                },
                new Book
                {
                    Name = "Agile Principles, Patterns, and Practices in C#",
                    Author = "Robert C. Martin",
                    PageCount = 732,
                    Publisher = "Prentice Hall"
                }
            };
        }

        [HttpGet]
        public IEnumerable<Book> Get() => books;
    }
}