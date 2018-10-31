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
            foreach (Book b in books)
            {
                if (b.ItemId == itemId)
                {
                    return b;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double result = 0;
            foreach  (Book b in books)
            {
                result = result + b.Price;
            }
            return result;
        }

    }
}
