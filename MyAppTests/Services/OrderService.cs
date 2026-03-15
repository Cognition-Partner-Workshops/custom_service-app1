using System.Collections.Generic;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public class OrderService
    {
        private readonly List<Order> _orders = new List<Order>();

        public void PlaceOrder(Order order) => _orders.Add(order);

        public Order GetOrderById(int id) => _orders.Find(o => o.OrderId == id);

        public List<Order> GetAllOrders() => _orders;
    }
}
