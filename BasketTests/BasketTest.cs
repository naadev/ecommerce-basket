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
        [Fact(DisplayName = "Given a basket with 2 items, And price for this item is 1.3, Then total ammount to pay will be 2.6")]
        public void TestC()
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = 1.3 },2);
            Assert.True(basket.Total() == 2.6);
        }
        [Fact(DisplayName = "Given a basket with 3 items, And price for this item is 1.3, Then total ammount to pay will be 3.9")]
        public void TestD()
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = 1.3 },3);
            Assert.True(basket.Total() == 3.9);
        }
        [Fact(DisplayName = "Given a basket with 4 items, And price for this item is 1.3, Then total ammount to pay will be 3.9")]
        public void TestE()
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = 1.3 },4);
            Assert.True(basket.Total() == 5.2);
        }
    }
}
