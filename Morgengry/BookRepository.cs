﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class BookRepository
    {
        
        private List<Book> books = new List<Book>();
        
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public Book GetBook(string itemId)
        {

        }
        public double GetTotalValue()
        {

        }
    }
}