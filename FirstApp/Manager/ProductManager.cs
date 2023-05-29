using FirstApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Manager
{
    public class ProductManager : IProductManager
    {
        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Insert(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}