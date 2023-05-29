using FirstApp.Context;
using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext db = new ProductContext();
        public ProductRepository()
        {
            
        }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}