using Core_App.Models.Book;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ViewResult Index()
        {
            return View(_bookRepository.GetAllBooks());
        }

        public ViewResult Details()
        {
            return View(_bookRepository.GetBook(1));
        }
    }
}
