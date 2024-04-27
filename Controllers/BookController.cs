using AutoMapper;
using BookstoreAPI.Data;
using BookstoreAPI.Data.Dtos.Book;
using BookstoreAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private BookContext _bookContext;
    private IMapper _mapper;
    public BookController(BookContext bookContext, IMapper mapper)
    {
        _bookContext = bookContext;
        _mapper = mapper;
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] CreateBookDto createBookDto)
    {
        Book book = _mapper.Map<Book>(createBookDto);
        _bookContext.Books.Add(book);
        _bookContext.SaveChanges();
        return Created(string.Empty, book);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
    public IEnumerable<Book> GetAllBooks()
    {
        return _bookContext.Books;
    }
}
