// Product.cs
using System;

public class Product
{
    public string ProductId { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Product(string productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: ${Price:F2}");
    }
}
