using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTestPromotionEngine
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

        [TestMethod]
        public void ScenarioB()
        {
            var order = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C")
            });

            var totalPrice = order.GetTotalPrice();

            Assert.AreEqual(totalPrice, 370);
        }

        [TestMethod]
        public void ScenarioC()
        {
            var order = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C"),
                new Product("D")
            });

            var totalPrice = order.GetTotalPrice();

            Assert.AreEqual(totalPrice, 280);
        }
    }
}
