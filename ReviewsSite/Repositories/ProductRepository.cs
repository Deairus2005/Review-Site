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

        public void Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetReviews()
        {
            throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
