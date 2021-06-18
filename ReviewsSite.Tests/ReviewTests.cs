using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {

        Review sut;

        [Fact]
        public void ReviewConstructor_Sets_Rating_On_Review()
        {
            //sut = new Review(5,4, "", "");

            Assert.Equal(4, sut.Rating);
        }
        [Fact]
        public void ReviewConstructor_Sets_Name_On_Review()
        {
           // sut = new Review(6,5, "Pearl", "");

           // Assert.Equal("Pearl", sut.Name);
        }
        [Fact]
        public void ReviewConstructor_Sets_Review_Content_On_Review()
        {
            //sut = new Review(8,3, "", "Totes would buy this product!");

            Assert.Equal("Totes would buy this product!", sut.ReviewContent);
        }
    }
}
