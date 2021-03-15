using System;
using System.Collections.Generic;

namespace GherkinTests
{
    internal class Basket
    {
        double Fidelity { get; set; } = 0.0;
        public Basket(double fidelity = 0.0)
        {
            Fidelity = fidelity;
        }

        internal double Total()
        {
            double total = 0.0;
            Items.ForEach(x => total += (x.Price * (100 - x.Discount) / 100));
            total = Math.Round(total * (100 - Fidelity) / 100, 2);
            return total;
        }
        public List<Item> Items { get; set; } = new List<Item>();
        internal void AddItem(Item item, int quantity = 1)
        {
            for (int i = 0; i < quantity; i++)
            {
                Items.Add(item);
            }
        }
    }
}