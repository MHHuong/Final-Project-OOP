using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Management_System
{
    public class Book
    {
        string title;
        string author;
        int isbn;

        public Book(string title, string author, int isbn)
        {
            this.title = title;
            this.author = author;
            this.Isbn = isbn;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Isbn { get => isbn; set => isbn = value; }

        public string DisplayBookInfo()
        {
            return $"Title: {title}, Author: {author}, ISBN: {isbn}";
        }
    }
}