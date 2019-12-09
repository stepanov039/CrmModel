using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //arrange

            var customer = new Customer
            {
                Name = "Тест пользователь"
            };

            var product1 = new Product()
            {
                Name ="Тест продукт1",
                Price = 100,
                Count = 10 
            };

            var product2 = new Product()
            {
                Name = "Тест продукт1",
                Price = 100,
                Count = 20
            };
            //act

            var card = new Cart(customer);
            card.Add(product1);
            card.Add(product1);
            card.Add(product2);


            var expectedResult = new List<Product>()
            {
                product1,product2,product2
            };
            //assert

            var CartAll = card.GetAll();

            Assert.AreEqual(expectedResult.Count, CartAll.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i],CartAll[i]);
            }
        }

    }
}