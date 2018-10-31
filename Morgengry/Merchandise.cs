using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {
        private string itemId;

        public double GetValue() {
            return Utility.GetValueOfMerchandise(this);
        }
        
        //public Merchandise(string itemId)
        //{
        //    ItemId = itemId;
        //}

        public  string ItemId { get {return this.itemId; } set {this.itemId = value; } }


        public override string ToString()
        {
            return "ItemId: " +  itemId;
        }
    }
}
