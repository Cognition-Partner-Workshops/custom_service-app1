using System;
using System.Collections.Generic;

namespace OrderManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
