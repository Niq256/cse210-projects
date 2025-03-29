using System;

class Program
{
    static void Main(string[] args)
    {
        // Address objects
            Address address1 = new Address("Al Andalus St", "Al NASR", "Doha", "Qatar");
            Address address2 = new Address("789 Oak Ave", "Los Angeles", "CA", "USA");

            // Customer objects
            Customer customer1 = new Customer("Twesigye Niclous", address1);
            Customer customer2 = new Customer("Kansiime Sophia", address2);

            // Product objects
            Product product1 = new Product("Microwave", "MW012", 95.25m, 5);
            Product product2 = new Product("Refrigerator", "RF456", 909.50m, 2);
            Product product3 = new Product("Washing Machine", "WM789", 545.50m, 1);

            // Order objects
            List<Product> order1Products = new List<Product> { product1, product2 };
            List<Product> order2Products = new List<Product> { product2, product3 };

            Order order1 = new Order(order1Products, customer1);
            Order order2 = new Order(order2Products, customer2);

            // Displaying results for Order 1
            Console.WriteLine(order1.GeneratePackingLabel());
            Console.WriteLine(order1.GenerateShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

            Console.WriteLine();

            // Displaying results for Order 2
            Console.WriteLine(order2.GeneratePackingLabel());
            Console.WriteLine(order2.GenerateShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
        }
    }