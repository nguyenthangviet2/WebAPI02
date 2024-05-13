using WebAPI02.Models.Domain;
using WebAPI02.Models.DTO;

namespace WebAPI02.Repositories
{
    public interface IBookRepository
    {
        //List<BookDTO> GetAllBooks();
        //BookDTO GetBookById(int id);
        //AddBookRequestDTO AddBook(AddBookRequestDTO addBookRequestDTO);
        //AddBookRequestDTO? UpdateBookById(int id, AddBookRequestDTO bookDTO);
        //Books? DeleteBookById(int id);


        List<BookDTO> GetAllBooks(string? filterOn = null, string? filterQuery = null, string? sortBy = null,
        bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
        BookDTO GetBookById(int id);
        AddBookRequestDTO AddBook(AddBookRequestDTO addBookRequestDTO);
        AddBookRequestDTO? UpdateBookById(int id, AddBookRequestDTO bookDTO);
        Books? DeleteBookById(int id);
    }
   
    
}

