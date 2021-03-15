namespace BasketTests
{
    internal class Item
    {
        public double Price { get; set; }
        public double Discount { get; internal set; } = 0.0;
    }
}