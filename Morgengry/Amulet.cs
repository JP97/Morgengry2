using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Amulet
    {
        private string _itemId;
        private int _quality;
        private string _design;


        public string ItemId { get { return _itemId; } set { this._itemId = value; } }
        public string Design { get{ return _design; } set { this._design = value; } }
        public int Quality { get { return _quality; } set { this._quality = value; } }


        public Amulet(string itemId, int quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, int quality) :
            this (itemId, quality, "Not supplied")
        {
            
        }
        public Amulet(string itemId) 
            : this (itemId, 0 ,"Not Supplied")
        {
            
        }
        
        
        
    }
}
