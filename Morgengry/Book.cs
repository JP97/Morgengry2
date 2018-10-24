﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Book
    {
        private string itemId;
        private string title;
        private double price;
        //jkrgberg
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public Book(string itemId, string title): 
            this(itemId, title, 0)
        {

        }
        public Book(string itemId):
            this(itemId, "not given", 0)
        {

        }

        public string ItemId { get {return this.itemId; } set {this.itemId = value ; } }
        public string Title { get {return this.title; } set {this.title = value; } }
        public double Price { get {return this.price; } set {this.price = value; } }

    }
}
