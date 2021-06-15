using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Rating { get; set; }
        public string Name { get; set; }
        public string ReviewContent { get; set; }

        public Review(int rating, string name, string reviewContent)
        {
            Rating = rating;
            Name = name;
            ReviewContent = reviewContent;
        }
    }
}
