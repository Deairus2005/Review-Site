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
        public Review Review { get; set; }

        public Product(int id, string name, string image, string category)
        {
            Id = id;
            Name = name;
            Image = image;
            Category = category;
        }
        public void AddReview(Review myReview)
        {
            Review = myReview;
        }

    }
}
