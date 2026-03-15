using System.Collections.Generic;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product) => _products.Add(product);

        public Product GetProductById(int id) => _products.Find(p => p.ProductId == id);

        public List<Product> GetAllProducts() => _products;
    }
}
