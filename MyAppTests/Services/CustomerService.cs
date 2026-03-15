using System.Collections.Generic;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public class CustomerService
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public void RegisterCustomer(Customer customer) => _customers.Add(customer);

        public Customer GetCustomerById(int id) => _customers.Find(c => c.CustomerId == id);

        public List<Customer> GetAllCustomers() => _customers;
    }
}
