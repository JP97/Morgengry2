using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {

        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string ID)
        {
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (merchandises[i].ItemId == ID)
                {
                    return merchandises[i];
                }
            }
            return null;

        }
       
        
        public double GetTotalValueOfMerchandise (Merchandise merchandise)
        {
            double result = 0;
            foreach (Merchandise m in merchandises)
            {
                result += m.GetValue();
            }
            return result;
        }
    }
}
