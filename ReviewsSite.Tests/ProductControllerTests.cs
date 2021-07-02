using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ProductControllerTests
    {
        ProductController sut;
        IRepository<Product> productRepo;
        IRepository<Review> reviewRepo;

        public ProductControllerTests()
        {
            productRepo = Substitute.For<IRepository<Product>>();
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ProductController(productRepo, reviewRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Delete_Displays_Product_To_Delete_Successfully()
        {
            var product = new Product(1, "testProduct", "test.jpg", "testCategory");

            productRepo.GetById(1).Returns(product);
            productRepo.GetAll().Returns(new List<Product>());

            var result = sut.Delete(1);

            Assert.Equal(product, result.Model);
        } 

        [Fact]
        public void Create_Returns_A_View()
        {
            var result = sut.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Returns_A_View()
        {
            var productToUpdate = new Product();
            productRepo.GetById(1).Returns(productToUpdate);
            var result = sut.Update(1);

            Assert.IsType<ViewResult>(result);
        }
    }
}
