namespace Backpack
{
    public class Item
    {
        public Item (int weight, double price)
        {
            Weight = weight;
            Price = price;
        }

        public int Weight { get; set; }
        public double Price { get; set; }

        public double Relationship
        {
            get { return Price / Weight; }
        }

    }
}
