using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        public IRepository<Review> reviewRepo;
        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public IActionResult Index()
        {
            return View(reviewRepo.GetAll());
        }
        
        public IActionResult Create(int id)
        {
            ViewBag.Product = new List<Product>() { reviewRepo.GetProductById(id) };
            return View(new Review() { ProductId = id });
        }

        [HttpPost]
        public IActionResult Create(Review model)
        {
            reviewRepo.Create(model);
            return RedirectToAction("Details", "Product", new {id = model.ProductId });
        }

        public IActionResult Update(int id)
        {
            Review review = reviewRepo.GetById(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Update(Review model)
        {
            reviewRepo.Update(model);
            ViewBag.ResultMessage = "This review was successfully updated";
            return RedirectToAction("Details", "Product", new { id = model.ProductId });
        }


    }
}
