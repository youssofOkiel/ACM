using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;


namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidationTest()
        {
            //--Arrange
            var product = new Product
            {
                productName = "milk",
                description = "just milk",
                currrntPrice = .5f
            };

            bool expected = true;

            //--Act
            bool actual = product.validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
