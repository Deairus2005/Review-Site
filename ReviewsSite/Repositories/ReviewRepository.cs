using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        public StoreContext db;

        public ReviewRepository(StoreContext db)
        {
           
            
                this.db = db;
            
        }

        public void Create(Review obj)
        {
            db.Reviews.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Review obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return db.Reviews.Where(r => r.ProductId == id).FirstOrDefault();
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

        public void Update(Review obj)
        {
            throw new NotImplementedException();
        }
    }
}
