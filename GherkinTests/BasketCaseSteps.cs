using System;
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
        
        [Then(@"total ammount to pay will be '(.*)'")]
        public void ThenTotalAmmountToPayWillBe(double total)
        {
            Assert.True(total == Basket.Total());
        }

        [Given(@"a basket with one item and price for this item is '(.*)'")]
        public void GivenABasketWithOneItemAndPriceForThisItemIs(double price)
        {
            GivenABasketWithItemsAndPriceForThisItemIs(1, price);
        }
        [Given(@"a basket with '(.*)' items and price for this item is '(.*)'")]
        public void GivenABasketWithItemsAndPriceForThisItemIs(int items, double price)
        {
            Basket.AddItem(new Item { Price = price }, quantity: items);
        }


    }
}
