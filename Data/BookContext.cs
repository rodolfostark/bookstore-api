using BookstoreAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookstoreAPI.Data;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bookstore.db");
    }
}
