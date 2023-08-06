using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x=>x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id=1, Title="MVC", Author = "Avinash"},
                new BookModel() {Id=2, Title="C#", Author = "Microsoft"},
                new BookModel() {Id=3, Title="OOPS", Author = "Nitish"},
                new BookModel() {Id=4, Title="Maths", Author = "RD Sharma"},
                new BookModel() {Id=5, Title="Physics", Author = "H.C Verma"}
            };
        }
    }
}
