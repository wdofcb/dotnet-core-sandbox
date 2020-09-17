using Core_App.Models.Book;
using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository { get; set; }

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public JsonResult Index()
        {
            return Json(_bookRepository.GetBook(1));
        }
    }
}
