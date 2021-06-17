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

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return db.Reviews.Where(r => r.ProductId == id).FirstOrDefault();
        }
    }
}
