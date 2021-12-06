using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Model

namespace GameStop_API.Services
{
    interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(int id, Product product);
        void Delete(int id);
    }
}
