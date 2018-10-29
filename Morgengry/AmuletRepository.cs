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

        }

        public double GetTotalValue()
        {
            
        }
    }
}
