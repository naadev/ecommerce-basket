using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace GherkinTests
{
    [Binding]
    public class BasketCaseSteps
    {
        Basket Basket { get; set; } = new Basket();
        [Given(@"an empty basket")]
        public void GivenAnEmptyBasket()
        {
            Basket = new Basket();
        }

        Item OneItem = new Item();
        [Given(@"a basket with one item and price for this item is '(.*)'")]
        public void GivenABasketWithOneItemAndPriceForThisItemIs(double price)
        {
            OneItem.Price = price;
            Basket.AddItem(OneItem);
        }
        [Given(@"a basket with '(.*)' items and price for this item is '(.*)'")]
        public void GivenABasketWithItemsAndPriceForThisItemIs(int quantity, double price)
        {
            Basket.AddItem(new Item { Price = price }, quantity);
        }
        [Given(@"discount of (.*)% is applied on item price")]
        public void GivenDiscountOfIsAppliedOnItemPrice(double discount)
        {
            OneItem.Discount = discount;
        }

        [Then(@"total ammount to pay will be '(.*)'")]
        public void ThenTotalAmmountToPayWillBe(double total)
        {
            Assert.True(total == Basket.Total());
        }

    }
}
