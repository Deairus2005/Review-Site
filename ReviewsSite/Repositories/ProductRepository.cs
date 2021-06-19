using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public StoreContext db;


        public ProductRepository(StoreContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
