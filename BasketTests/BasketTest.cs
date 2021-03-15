using System;
using System.Collections.Generic;
using Xunit;

namespace BasketTests
{
    public class BasketTest
    {
        [Fact(DisplayName = "Given an empty basket, Then total ammount to pay will be 0.0")]
        public void TestA()
        {
            var basket = new Basket();
            Assert.True(basket.Total() == 0.0);
        }

        [Fact(DisplayName = "Given a basket with 1 item, And price for this item is 1.3, Then total ammount to pay will be 1.3")]
        public void TestB()
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = 1.3 });
            Assert.True(basket.Total() == 1.3);
        }

    }
}
