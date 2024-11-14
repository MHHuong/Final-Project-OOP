using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public class Member : Person
    {
        int memberID;
        List<Book> borrowedBooks = new List<Book>();

        public List<Book> BorrowedBooks { get => borrowedBooks; set => borrowedBooks = value; }
        public int MemberID { get => memberID; set => memberID = value; }

        public Member(string name, ContactInformation contactInformation, int memberID) : base(name, contactInformation)
        {
            this.memberID = memberID;
        }
        public override string PrintDetails()
        {
            return $"Member: {base.PrintDetails()}";
        }
        public void IssueBook(Book book)
        {
            if (!BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Add(book);
                MessageBox.Show($"Book '{book.Title}' issued to Member ID: {memberID}");
            }
            else
            {
                MessageBox.Show($"Book '{book.Title}' is already issued.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                MessageBox.Show($"Book '{book.Title}' returned by Member ID: {memberID}");
            }
            else
            {
                MessageBox.Show($"Book '{book.Title}' was not borrowed by Member ID: {memberID}");
            }
        }
        public Book SearchBook(List<Book> catalog, string title)
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
        public Book SearchBook(List<Book> catalog, int isbn)
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

    }
}