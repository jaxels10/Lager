using Lager.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public Product product;

        public UnitTest1()
        {
            this.product = new Product(20, "coin");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(this.product.price, 20); 
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(this.product.name, "coin");
        }
    }
}
