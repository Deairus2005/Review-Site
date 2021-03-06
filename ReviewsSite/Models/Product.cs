using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Product Image")]
        [Required(ErrorMessage = "Please Choose File To Upload")]
        public string Image { get; set; }
        public string Category { get; set; }
        public virtual List<Review> Reviews { get; set; }

        public Product()
        {

        }

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
