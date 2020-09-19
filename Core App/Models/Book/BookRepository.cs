using System.Collections.Generic;
using System.Linq;

namespace Core_App.Models.Book
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books { get; set; }

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book(){ Id = 1 , Name = "Clean Code "},
                new Book(){ Id = 2 , Name = "C# Programming"},
                new Book(){ Id = 3 , Name = "C# Best Practices"},
            };
        }
        public Book GetBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }
    }
}
