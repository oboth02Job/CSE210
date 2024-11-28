using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Job Oboth", address1);
        Customer customer2 = new Customer("John Bosco", address2);

        // Create products
        Product product1 = new Product("Laptop", "P1001", 799.99m, 1);
        Product product2 = new Product("Mouse", "P1002", 19.99m, 2);
        Product product3 = new Product("Keyboard", "P1003", 49.99m, 1);

        Product product4 = new Product("Monitor", "P2001", 199.99m, 1);
        Product product5 = new Product("Webcam", "P2002", 89.99m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}
