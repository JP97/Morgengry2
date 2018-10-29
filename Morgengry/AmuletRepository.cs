using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet a)
        {
            amulets.Add(a);
        }

        public Amulet GetAmulet(string itemId)
        {
            throw new NotImplementedException();
        }
        
        public double GetTotalValue()
        {
            double result = 0;
            foreach (Amulet item in amulets)
            {
                result = result + Utility.GetValueOfAmulet(item);
            }

            return result;
        }
    }
}
