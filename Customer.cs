// Customer.cs
using System;

public class Customer
{
    public string CustomerId { get; private set; }
    public string Name { get; private set; }

    public Customer(string customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerId}");
        Console.WriteLine($"Name: {Name}");
    }
}
