using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

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
        public IActionResult Create(Product model, IFormFile Image)
        {
            Product existingProduct = productRepo.GetByName(model.Name);

            if (existingProduct == null && !String.IsNullOrEmpty(model.Name))
            {
                if(Image != null)
                {
                    string path = Directory.GetCurrentDirectory() + "\\wwwroot\\Uploads\\" + Image.FileName;
                    using (var fileStream = System.IO.File.Create(path))
                    {
                        Image.CopyTo(fileStream);
                    }
                    model.Image = "/Uploads/" + Image.FileName;
                }

                productRepo.Create(model);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ResultMessage = "Please Enter A Name That Does Not Already Exist And Is Not Blank.";

                return View(model);
            }
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

        public ViewResult Delete(int id)
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
