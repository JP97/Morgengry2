using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        //private List<Amulet> amulets = new List<Amulet>();
        //private List<Book> books = new List<Book>();
        private List<Merchandise> merchandises = new List<Merchandise>();


        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        //public void AddAmulet(Amulet a)
        //{
        //    amulets.Add(a);
        //}

        //public void AddBook(Book b)
        //{
        //    books.Add(b);
        //}


        public Merchandise GetMerchandise(string itemId)
        {
            for(int i = 0; i < merchandises.Count; i++)
            {
                if(merchandises[i].ItemId == itemId)
                {
                    return merchandises[i];
                }
            }
            return null;
        }

        //public Amulet GetAmulet(string itemId)
        //{
        //    for (int i = 0; i < amulets.Count; i++)
        //    {
        //        if (amulets[i].ItemId == itemId)
        //        {
        //            return amulets[i];
        //        }
        //    }
        //    return null;
        //}

        //public Book GetBook(string itemId)
        //{
        //    for (int i = 0; i < books.Count; i++)
        //    {
        //        if (books[i].ItemId == itemId)
        //        {
        //            return books[i];
        //        }
        //    }
        //    return null;
        //}
        public double GetTotalValueOfMerchandise(Merchandise merchandise)
        {
           double result = 0;

           foreach(Merchandise m in merchandises)
            {
                result += Utility.GetValueOfMerchandise(m);
            }

            return result;
        }
    }
}
