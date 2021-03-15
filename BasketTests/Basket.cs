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
            Items.ForEach(x => total += (x.Price * (100 - x.Discount) / 100));
            return Math.Round(total,2);
        }
        public List<Item> Items { get; set; } = new List<Item>();
        internal void AddItem(Item item, int quantity=1)
        {
            for (int i=0;i< quantity; i++)
            {
                Items.Add(item);
            }
        }
    }
}