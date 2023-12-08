// InventorySystem.cs
class InventorySystem
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("P001", "Laptop", 999.99);
        Product product2 = new Product("P002", "Smartphone", 499.99);

        // Create customers
        Customer customer1 = new Customer("C001", "John Doe");
        Customer customer2 = new Customer("C002", "Jane Smith");

        // Create orders
        Order order1 = new Order("O001", customer1);
        Order order2 = new Order("O002", customer2);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product2);

        // Display order information
        order1.DisplayInfo();
        System.Console.WriteLine();
        order2.DisplayInfo();
    }
}
