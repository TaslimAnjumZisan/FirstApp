﻿using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstApp.Manager
{
    public interface IProductManager
    {
        Task<Boolean> Insert(Product product);
        Task<Product> Update(int id);
        Task<Boolean> Update(Product product);

        Task<Boolean> Delete(int id);

        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
    }
}