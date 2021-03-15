using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GherkinTests
{
    [Binding]
    public class BasketCaseSteps
    {
        Basket Basket { get; set; } = null;
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
    }
}
