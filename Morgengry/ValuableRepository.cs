using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository 
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string itemId)
        {
            foreach(IValuable v in valuables)
            {
                if(v is Book book && book.ItemId == itemId)
                {
                    return v;
                }
                else if(v is Amulet amulet && amulet.ItemId == itemId)
                {
                    return v;
                }
                else if(v is Course course && course.Name == itemId)
                {
                    return v;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double totalvalue = 0.0;
            foreach (var valuable in valuables)
            {
                totalvalue = totalvalue + valuable.GetValue();
            }

            return totalvalue;
        }

        public int Count()
        {
            return valuables.Count;
        }


    
    }
}
