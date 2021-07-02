using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Extensions
{
    public interface ISelectList
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Review> GetReviews();
        Product GetProductById(int id);
        Product GetByName(string name);
    }
}
