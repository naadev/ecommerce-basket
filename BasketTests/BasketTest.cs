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
    }
}
