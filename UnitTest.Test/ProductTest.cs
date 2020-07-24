using Lager.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Test
{
    [TestClass]
    class ProductTest
    {
        private readonly ProductTest _productTest;
        public Product product; 

        public ProductTest()
        {
            _productTest = new ProductTest();
            this.product = new Product(20, "coin"); 
        }

        [TestMethod]
        public void testName()
        {
            Assert.AreEqual(product.name, "coin"); 
        }

        [TestMethod]
        public void testPrice()
        {
            Assert.AreEqual(product.price, 20);
        }
    }
}
