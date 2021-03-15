using System;

namespace BasketTests
{
    internal class Basket
    {
        public Basket()
        {
        }

        internal double Total()
        {
            return Item != null ? Item.Price : 0.0;
        }
        public Item Item { get; set; }
        internal void AddItem(Item item)
        {
            Item = item;
        }
    }
}