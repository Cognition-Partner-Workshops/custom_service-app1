using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    public class LibraryService
    {
        private readonly List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Book BorrowBook(string title)
        {
            var book = _books.FirstOrDefault(b => b.Title == title && b.IsAvailable);
            if (book != null)
            {
                book.IsAvailable = false;
            }
            return book;
        }

        public void ReturnBook(string title)
        {
            var book = _books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                book.IsAvailable = true;
            }
        }

        public List<Book> GetAvailableBooks()
        {
            return _books.Where(b => b.IsAvailable).ToList();
        }
    }
}
