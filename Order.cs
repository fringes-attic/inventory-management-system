// Order.cs
using System;
using System.Collections.Generic;

public class Order
{
    public string OrderId { get; private set; }
    public Customer Customer { get; private set; }
    public List<Product> Products { get; private set; }

    public Order(string orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Customer: {Customer.Name}");
        Console.WriteLine("Products:");
        foreach (var product in Products)
        {
            Console.WriteLine($"  - {product.Name}");
        }
    }
}
