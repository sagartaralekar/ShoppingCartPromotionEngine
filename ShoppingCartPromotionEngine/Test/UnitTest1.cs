using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL.Model;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScenarioA()
        {
            var order = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("B"),
                new Product("C")
            });

            var totalPrice = order.GetTotalPrice();

            Assert.AreEqual(totalPrice, 100);
        }
    }
}
