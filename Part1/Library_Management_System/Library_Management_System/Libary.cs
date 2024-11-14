using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management_System
{
    public class LibarySystem
    {
        List<Book> catalog = new List<Book>();
        public void  AddBook (Librarian librarian, Book book)
        {
            librarian.AddBook (book);
            catalog.Add (book);
        }
        public void IssueBook(Member member, Book book)
        {
            member.IssueBook (book);
        }
        public void ReturnBook(Member member, Book book)
        {
            member.ReturnBook (book);
        }
        public void SearchBook(Person person, int isbn)
        {
            if (person is Librarian librarian)
            {
                librarian.SearchBook(isbn);
            }
            else if (person is Member member)
            {
                member.SearchBook(catalog, isbn);
            }
        }

        public void ViewMemberDetails(Librarian librarian, Member member)
        {
            librarian.ViewMemberDetails(member);
        }

        public void GenerateReport(Librarian librarian)
        {
            librarian.GenerateReport();
        }
    }
}