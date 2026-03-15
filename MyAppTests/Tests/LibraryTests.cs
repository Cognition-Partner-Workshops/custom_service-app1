using System;
using LibraryApp.Models;
using LibraryApp.Services;

namespace LibraryApp.Tests
{
    public class LibraryTests
    {
        public void Run()
        {
            var libraryService = new LibraryService();
            var memberService = new MemberService();

            // Add books
            libraryService.AddBook(new Book { Title = "C# Basics", Author = "John Doe" });
            libraryService.AddBook(new Book { Title = "Advanced .NET", Author = "Jane Smith" });

            // Register member
            memberService.RegisterMember(new Member { Name = "Alice", MemberId = 1 });

            // Borrow book
            var borrowedBook = libraryService.BorrowBook("C# Basics");
            Console.WriteLine(borrowedBook != null ? "Borrow Test Passed" : "Borrow Test Failed");

            // Return book
            libraryService.ReturnBook("C# Basics");
            var availableBooks = libraryService.GetAvailableBooks();
            Console.WriteLine(availableBooks.Exists(b => b.Title == "C# Basics") ? "Return Test Passed" : "Return Test Failed");
        }
    }
}
