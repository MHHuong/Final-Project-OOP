using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class Librarian : Person
    {
        private List<Book> catalog = new List<Book>();
        public Librarian(string name, ContactInformation contactInformation) : base(name, contactInformation)
        {
        }
        public void AddBook(Book book)
        {
            catalog.Add(book);
            MessageBox.Show($"Book {book.Title} added successfully!");
        }
        public Book SearchBook(string title)
        {
            var book = catalog.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                MessageBox.Show($"Found by Title: {book.DisplayBookInfo()}");
                return book;
            }
            else
            {
                MessageBox.Show("Book not found by title.");
                return null;
            }
        }
        public Book SearchBook(int isbn)
        {
            var book = catalog.Find(b => b.Isbn == isbn);
            if (book != null)
            {
                MessageBox.Show($"Found by ISBN: {book.DisplayBookInfo()}");
                return book;
            }
            else
            {
                MessageBox.Show("Book not found by ISBN.");
                return null;
            }
        }
        public override string PrintDetails()
        {
            return $"Librarian, {base.PrintDetails()}";
        }
        public void ViewMemberDetails(Member member)
        {
            member.PrintDetails();
            Console.WriteLine("Borrowed Books:");
            foreach (var book in member.BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title}");
            }
        }
        public void GenerateReport()
        {
            Console.WriteLine("Library Report:");
            Console.WriteLine("Books in Catalog:");
            foreach (var book in catalog)
            {
                Console.WriteLine($"- {book.DisplayBookInfo()}");
            }
        }
    }
}