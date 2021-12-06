using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Model;

namespace GameStop_API.Services
{
    public class ScaffoldingProductService : IProductService
    {
        private static ScaffoldingProductService _instance;

        public static ScaffoldingProductService GetInstance()
        {
            if (_instance == null)
                _instance = new ScaffoldingProductService();

            return _instance;
        }

        // I Campi Private per convenzione dovrebbero iniziare con _
        private List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1, Name = "Gaming mouse", Category = "Gaming", Price = 19.99
            },
            new Product
            {
                Id = 2, Name = "Notebook", Category = "Electronic", Price = 1200.99
            },
            new Product
            {
                Id = 3, Name = "Phone charger", Category = "Accessories", Price = 9.99
            },
            new Product
            {
                Id = 4, Name ="Monitor", Category ="Electronic", Price = 998.99
            }
        };

        private int _lastId = 4;

        private ScaffoldingProductService() { }

        public void AddProduct(Product product)
        {
            product.Id = _lastId++;
            _products.Add(product);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
