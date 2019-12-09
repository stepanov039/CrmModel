using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Generator
    {
        Random rnd = new Random();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();


        private static string GetRandomText() 
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
        public List<Customer> GetNewCustomer(int count)
        {
            Customers = new List<Customer>();
            for (var i = 0; i < count; i++)
            {
                var customer = new Customer
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText()
                };
                Customers.Add(customer);
            }
            return Customers;
        }

        public List<Seller> GetNewSeller(int count)
        {
            Sellers = new List<Seller>();
            for (var i = 0; i < count; i++)
            {
                var seller = new Seller
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText()
                };
                Sellers.Add(seller);
            }
            return Sellers;
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);
            for (var i = 0; i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count -1)]);
            }
            return result;
        }
        public List<Product> GetNewProduct(int count)
        {
            for (var i = 0; i < count; i++)
            {
                var product = new Product
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10,100),
                    Price = rnd.Next(100,1000)
                };
                Products.Add(product);
            }
            return Products;
        }
    }
}
