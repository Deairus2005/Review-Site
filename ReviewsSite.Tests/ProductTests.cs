using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ProductTests
    {
        Product sut = new Product(47, "", "", "");


        [Fact]
        public void ProductConstructor_Sets_Id_On_Product()
        {
            sut = new Product(47, "", "", "");

            Assert.Equal(47, sut.Id);

        }

        [Fact]
        public void ProductConstructor_Sets_Name_On_Product()
        {
            sut = new Product(23, "Toilet Paper", "", "");

            Assert.Equal("Toilet Paper", sut.Name);
        }
        [Fact]
        public void ProductConstructor_Sets_Image_On_Product()
        {
            sut = new Product(22, "Soap", "Soap.PNG", "");

            Assert.Equal("Soap.PNG", sut.Image);
        }
        [Fact]
        public void ProductConstructor_Sets_Category_On_Product()
        {
            sut = new Product(53, "", "", "Personal Hygiene");

            Assert.Equal("Personal Hygiene", sut.Category);
        }
        [Fact]
        public void AddReview_Adds_Review_To_Product()
        {
            sut = new Product(53, "", "", "Personal Hygiene");

           // Review myReview = new Review(42, "Hello!", "");

           // sut.AddReview(myReview);

            //Assert.Equal(42, sut.Review.Rating);
        }

    }
}
