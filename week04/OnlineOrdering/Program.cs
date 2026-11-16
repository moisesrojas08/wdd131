using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "KB-104", 79.99, 1));
        order1.AddProduct(new Product("Ergonomic Optical Mouse", "MS-208", 29.50, 2));
        order1.AddProduct(new Product("USB-C Docking Station", "DK-315", 45.00, 1));

        Address address2 = new Address("Av. Universitaria 1801", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Mateo Rojas", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("27-Inch 4K Monitor", "MN-502", 320.00, 1));
        order2.AddProduct(new Product("Adjustable Laptop Stand", "ST-119", 24.99, 2));
        order2.AddProduct(new Product("Noise-Cancelling Headphones", "HP-880", 115.00, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        Console.WriteLine("=== ONLINE ORDERING SYSTEM REPORT ===\n");

        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"================ ORDER #{orderNumber} ================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Order Price: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("==========================================\n");
            orderNumber++;
        }
    }
}
