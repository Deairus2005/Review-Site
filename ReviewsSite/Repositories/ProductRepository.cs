using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public List<Product> productList;

        public ProductRepository()
        {
            productList = new List<Product>()
            {
                new Product(11, "Hand Soap", "handSoap.png", "Personal Hygiene"),
                new Product(55, "Deodorant", "deodorant.png", "Personal Hygiene"),
                new Product(23, "Shampoo", "shampoo.png", "Health Beauty"),
                new Product(67, "Facial Cleanser", "facialCleanser.png", "Health Beauty"),
                new Product(02, "Cotton Swabs", "cottonSwabs.png", "Personal Hygiene")
            };

        }

        public IEnumerable<Product> GetAll()
        {
            return productList;
        }

        public Product GetById(int id)
        {
            return productList.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
