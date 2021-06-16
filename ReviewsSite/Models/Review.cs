using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string Name { get; set; }
        public string ReviewContent { get; set; }

        public Review(int rating, int productId, string name, string reviewContent)
        {
            ProductId = productId;
            Rating = rating;
            Name = name;
            ReviewContent = reviewContent;
        }
    }
}
