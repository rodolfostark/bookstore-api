using AutoMapper;
using BookstoreAPI.Data.Dtos.Book;
using BookstoreAPI.Entities;

namespace BookstoreAPI.Profiles;


public class BookProfile : Profile
{
    public BookProfile() 
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<Book, ReadBookDto>();
        CreateMap<UpdateBookDto, Book>();
    }
}
