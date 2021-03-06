﻿using System;
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
        //private string _itemId;
        private Level _quality;
        private string _design;
        private double lowQualityValue;
        private double mediumQualityValue;
        private double highQualityValue;


        //public string ItemId { get { return _itemId; } set { this._itemId = value; } }
        public string Design { get{ return _design; } set { this._design = value; } }
        public Level Quality { get { return _quality; } set { this._quality = value; } }
        public double LowQualityValue { get { return this.lowQualityValue; } set { this.lowQualityValue = value; } }
        public double MediumQualityValue { get { return this.mediumQualityValue; } set { this.mediumQualityValue = value; } }
        public double HighQualityValue { get { return this.highQualityValue; } set { this.highQualityValue = value; } }


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
            string id = "ItemId: " + ItemId + "," + " Quality: " + Quality + "," + " Design: " + Design;
            return id;
        }

   
    }
}
