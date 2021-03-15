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
        [Theory(DisplayName = "Given a basket of n items, and price for this item is x, total will be calculated")]
        [InlineData(1.3, 1, 1.3)]
        [InlineData(1.3, 2, 2.6)]
        [InlineData(1.3, 3, 3.9)]
        [InlineData(1.3, 4, 5.2)]
        [InlineData(1.3, 5, 6.5)]
        public void TestF(double price,int quantity,double total)
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = price }, quantity);
            Assert.True(basket.Total() == total);
        }
        [Theory(DisplayName = "Given a basket of n items, and price for this item is x, total will be calculated")]
        [InlineData(1.3, 1, 10, 1.17)]
        [InlineData(1.3, 2, 10, 2.34)]
        [InlineData(1.3, 3, 10, 3.51)]
        [InlineData(1.3, 4, 10, 4.68)]
        [InlineData(1.3, 5, 10, 5.85)]
        public void TestG(double price, int quantity, double discount, double total)
        {
            var basket = new Basket();
            basket.AddItem(new Item { Price = price, Discount = discount }, quantity);
            Assert.True(basket.Total() == total);
        }
    }
}
