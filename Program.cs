using Backpack;
using System.Text;

List<Item> items = new List<Item>() 
{
    new Item(2, 1000), 
    new Item(3, 500), 
    new Item(5, 1500), 
    new Item(7, 700), 
    new Item(1, 600), 
    new Item(4, 1800), 
    new Item(1, 300) 
};

double fullPrice = 0, backPackWeight = 15;
StringBuilder sb = new StringBuilder();

foreach (var item in items.OrderByDescending(r => r.Relationship))
{
    if (item.Weight <= backPackWeight)
    {
        fullPrice += item.Price;
        backPackWeight -= item.Weight;
        sb.AppendLine($"Цена: {item.Price} - Вес: {item.Weight}");
    }
}

Console.WriteLine(sb);
Console.WriteLine($"Общая стоимость: {fullPrice}");
