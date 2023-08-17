using System;
using System.Collections.Generic;
using System.Text;
﻿//Gabriel Faustino CB3005399
namespace WebTrab01
{
    interface IRepositoryBook
    {
        BookList ToRead { get; }

        BookList Reading { get; }

        BookList Read { get; }

        IEnumerable<Book> All { get; }

        void Add(Book book);
    }
}
