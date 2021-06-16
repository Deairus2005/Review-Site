using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ProductController : Controller
    {
        public ProductRepository repo;
        public ProductController()
        {
            repo = new ProductRepository();
        }

        public ViewResult Index()
        {
            return View(repo.GetAll());
        }
    }
}
