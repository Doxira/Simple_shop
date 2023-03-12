using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using Simple_Shop.Core.Models;
using System.Runtime.Remoting.Channels;

namespace Simple_Shop.DataAcess.InMemory
{
    public class ProductRepository
    {
        ObjectCache cache = MemoryCache.Default;

        List<Product> products;

        public ProductRepository()
        {
            products = cache["products"] as List<Product>;

            if (products == null)
            {
                products = new List<Product>();
            }
        }

        public void commit ()
        {
            cache["products"] = products;
        }

        public void Insert(Product product)
        {
            products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = products.Find(p => p.ID == product.ID);

            if (productToUpdate != null)
            {
                productToUpdate = product;
            }
            else 
            {
                throw new Exception("Product not found");
            }
        }

        public Product Find (string Id)
        {
            Product product = products.Find(p => p.ID == Id);

            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public IQueryable<Product> Collection()
        {
            return products.AsQueryable();
        }

        public void Delete(string Id) 
        {
            Product productToDelete = products.Find(p => p.ID == Id);

            if (productToDelete != null)
            {
                products.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}
