using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BasketTests
{
    internal class Basket
    {
        public Basket()
        {
        }

        internal double Total()
        {
            double total = 0.0;
            Items.ForEach(x => total = total + x.Price);
            return total;
        }
        public List<Item> Items { get; set; } = new List<Item>();
        internal void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}