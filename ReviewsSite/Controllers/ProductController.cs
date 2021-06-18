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
        public IRepository<Product> productRepo;
        public ProductController(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }

        public ViewResult Index()
        {
            return View(productRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            Product myProduct = productRepo.GetById(id);
           
            return View(productRepo.GetById(id));
        }
    }
}
