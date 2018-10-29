using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        
        private List<Book> books = new List<Book>();
        
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public Book GetBook(string itemId)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].ItemId == itemId)
                {
                    return books[i];
                }
            }
            return null;
            
        }
        public double GetTotalValue()
        {
            double result = 0;

            foreach(Book b in books)
            {
                result = result + Utility.GetValueOfBook(b);
            }

            return result;
        }

    }
}
