using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository repository;
        public BookController() 
        {
            repository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data =  repository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return repository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return repository.SearchBook(bookName, authorName);
        }
    }
}
