using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
﻿//Gabriel Faustino CB3005399
namespace WebTrab01
{
    class BookList
    {
        private List<Book> _books;

        public string Title { get; set;}

        public BookList(string title, params Book[] books)
        {
            Title = title;
            _books = books.ToList();
            _books.ForEach(b => b.list = this);
        }

        public IEnumerable<Book> Books
        {
            get { return _books; }
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine(Title);
            linhas.AppendLine("====================");
            foreach (var book in Books)
            {
                linhas.AppendLine(book.ToString());
            }
            return linhas.ToString();
        }
    }
}
