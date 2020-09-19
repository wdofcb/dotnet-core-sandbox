using System.Collections.Generic;

namespace Core_App.Models.Book
{
    public interface IBookRepository
    {
        Book GetBook(int id);
        IEnumerable<Book> GetAllBooks();
    }
}
