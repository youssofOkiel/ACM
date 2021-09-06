using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ACM.BLTest
{
    [TestClass]
    public class CusromerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "youssof",
                LastName = "okiel",
            };
            string expected = "youssof_okiel";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void staticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "ali";
            Customer.instanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "youssof";
            Customer.instanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "ammar";
            Customer.instanceCount += 1;

            int expected = 3;

            //--Act
            int actual = Customer.instanceCount;

            //--Assert
            Assert.AreEqual(expected, actual);
        } [TestMethod]
        public void validationTest()
        {
            //--Arrange
            var c = new Customer
            {
                FirstName = "youssof",
                Email = "youssofOkiel@gmail.com "
            };

            bool expected = true;

            //--Act
            bool actual = c.validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        } 
        
        [TestMethod]
        public void validationMissingLastNameTest()
        {
            //--Arrange
            var c = new Customer
            {
                Email = "youssofOkiel@gmail.com "
            };

            bool expected = false;

            //--Act
            bool actual = c.validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
