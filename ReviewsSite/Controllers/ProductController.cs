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
        public IRepository<Review> reviewRepo;
        public ProductController(IRepository<Product> productRepo, IRepository<Review> reviewRepo)
        {
            this.productRepo = productRepo;
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            return View(productRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            Product myProduct = productRepo.GetById(id);
           
            return View(myProduct);
        }

        public IActionResult Create()
        {
            ViewBag.Products = productRepo.GetAll();

            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            //Product existingProduct = productRepo.GetByName(model.Name);

            //if (existingProduct == null)
            //{
            //    productRepo.Create(model);

            //    return RedirectToAction("Index");
            //}

            //ViewBag.ResultMessage = "That Product already exists.";

            //return View(model);

            productRepo.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Reviews = reviewRepo.GetAll();

            Product product = productRepo.GetById(id);

            return View(product);
        } 

        [HttpPost]
        public IActionResult Update(Product model)
        {
            productRepo.Update(model);

            ViewBag.ResultMessage = "This product was successfully updated";

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Product product = productRepo.GetById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            productRepo.Delete(product);

            return RedirectToAction("Index");
        }
    }
}
