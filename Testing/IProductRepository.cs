using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository 
    {
        public IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
    }
}
