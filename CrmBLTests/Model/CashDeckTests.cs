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
    public class CashDeckTests
    {
        [TestMethod()]
        public void CashDeckTest()
        {
            //arrange
            var customer1 = new Customer()
            {
                Name = "test",
                CustomerId = 1
            };
            var customer2 = new Customer()
            {
                Name = "test2",
                CustomerId = 2
            };

            var seller = new Seller()
            {
                SellerId = 1,
                Name = "Продовец 1"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "Товар 1",
                Count = 10,
                Price = 11
            };

            var product2 = new Product()
            {
                ProductId = 2,
                Name = "Товар 2",
                Count = 20,
                Price = 21
            };

            var product3 = new Product()
            {
                ProductId = 3,
                Name = "Товар 3",
                Count = 30,
                Price = 31
            };


            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product2);
            cart1.Add(product3);


            var cart2 = new Cart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);
            cart2.Add(product1);

            var cashDesk = new CashDesk(1, seller);
            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);


            var cart1ExpectedResult = 63;
            var cart2ExpectedResult = 64;
            //act

            var cart1ActualResult = cashDesk.Dequeue();
            var cart2ActualResult = cashDesk.Dequeue();
            //assert

            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
        }

        
      
    }
}
