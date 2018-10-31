using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    }
    
    public class Amulet : Merchandise
    {
        private string _itemId;
        private Level _quality;
        private string _design;


        public string ItemId { get { return _itemId; } set { this._itemId = value; } }
        public string Design { get{ return _design; } set { this._design = value; } }
        public Level Quality { get { return _quality; } set { this._quality = value; } }


        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) :
            this (itemId, quality, "")
        {
            
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium, "")
        {

        }




        public override string ToString()
        {
            string id = "ItemId: " + _itemId + "," + " Quality: " + _quality + "," + " Design: " + _design;
            return id;
        }
    }
}
