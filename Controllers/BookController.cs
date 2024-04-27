using BookstoreAPI.Data.Dtos.Book;
using BookstoreAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] CreateBookDto createBookDto)
    {
        var book = new Book();
        return Created();
    }
}
