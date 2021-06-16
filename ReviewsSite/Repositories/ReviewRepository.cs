using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        public List<Review> reviewList;

        public ReviewRepository()
        {
            reviewList = new List<Review>()
            {
                new Review(5, 11, "Hand Soap", "\nGentle on the hands and smells pretty!"),
                new Review(2, 55, "Deodorant", "\nLeft me stanky and moist!  Terrible.")
            };
        }

        public IEnumerable<Review> GetAll()
        {
            return reviewList;
        }

        public Review GetById(int id)
        {
            return reviewList.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
