using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public virtual List<Review> Reviews { get; set; }

        public Product(int id, string name, string image, string category)
        {
            Id = id;
            Name = name;
            Image = image;
            Category = category;
            Reviews = new List<Review>();
        }
        public void AddReview(Review myReview)
        {
            Reviews.Add(myReview);
        }

    }
}
