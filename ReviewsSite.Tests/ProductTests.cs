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
        public class ReviewTests
        {

            Product sut;

            [Fact]
            public void ProductConstructor_Sets_Id_On_Product()
            {
                sut = new Product(1, "", "", "");

                Assert.Equal(1, sut.Id);
            }

            [Fact]
            public void ProductConstructor_Sets_Name_On_Product()
            {
                sut = new Product(1, "Test", "", "");

                Assert.Equal("Test", sut.Name);
            }
            [Fact]
            public void ProductConstructor_Sets_Image_On_Product()
            {
                sut = new Product(1, "", "Image.jpg", "");

                Assert.Equal("Image.jpg", sut.Image);
            }
            [Fact]
            public void ProductConstructor_Sets_Category_On_Product()
            {
                sut = new Product(1, "", "", "CategotyTest");

                Assert.Equal("CategotyTest", sut.Category);
            }

        }
    }
}
