using System;
using OrderManagement.Models;
using OrderManagement.Services;

namespace OrderManagement.Tests
{
    public class OrderTests
    {
        public void Run()
        {
            var productService = new ProductService();
            var customerService = new CustomerService();
            var orderService = new OrderService();

            // Add products
            productService.AddProduct(new Product { ProductId = 1, Name = "Laptop", Price = 75000 });
            productService.AddProduct(new Product { ProductId = 2, Name = "Mouse", Price = 1500 });

            // Register customer
            var customer = new Customer { CustomerId = 1, Name = "Shakthi", Email = "shakthi@example.com" };
            customerService.RegisterCustomer(customer);

            // Place order
            var order = new Order { OrderId = 101, Customer = customer };
            order.Products.Add(productService.GetProductById(1));
            order.Products.Add(productService.GetProductById(2));

            orderService.PlaceOrder(order);

            Console.WriteLine("Order Test: " + 
                (order.GetTotalAmount() == 76500 ? "Passed" : "Failed"));
        }
    }
}
