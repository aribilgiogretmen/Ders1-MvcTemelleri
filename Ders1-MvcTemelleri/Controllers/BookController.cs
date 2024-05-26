using Ders1_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1_MvcTemelleri.Controllers
{
    public class BookController : Controller
    {

        private static List<Book> books = new List<Book>
        {
            new Book{ Id = 1,Title="Harry Potter",Author="J.k Rowling"},
            new Book{ Id = 2,Title="Şeker Portakalı",Author="José Mauro de Vasconcelos"}
        };
        


        [HttpGet("/Books")]
        public IActionResult Index()
        {

            return View(books);
        }



        [HttpGet("/Books/Create")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost("/Books/Create")]
        public IActionResult Create(Book book)
        {

            book.Id = books.Count + 1;
            books.Add(book);

            return RedirectToAction("Index");
        }
    }
}
