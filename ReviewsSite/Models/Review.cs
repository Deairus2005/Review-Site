using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Rating { get; set; }
        [Display(Name = "Name")]
        public string AuthorName { get; set; }
        public string ReviewContent { get; set; }

        public Review()
        {

        }
        public Review(int id, int productId, string authorName, string reviewContent, int rating)
        {
            Id = id;
            ProductId = productId;
            Rating = rating;
            AuthorName = authorName;
            ReviewContent = reviewContent;
        }
    }
}
