using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputerModel
    {
        public ShopComputerModel()
        {
            var sellers = Generator.GetNewSeller(20);
            Generator.GetNewProduct(1000);
            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }
            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }
        Random rnd = new Random();
        bool isWorking = false;
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();
        Generator Generator = new Generator();
        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();

        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;

        public void Start()
        {
            isWorking = true;
            Task.Run(() => CreateCarts(10));

            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c)));

            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        public void Stop()
        {
            isWorking = false;
        }

        private void CashDeskWork(CashDesk cashDesk)
        {
            while (isWorking)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }
        private void CreateCarts(int customerCounts)
        {
            while (isWorking)
            {
                var customers = Generator.GetNewCustomer(customerCounts);
                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in Generator.GetRandomProducts(10, 30))
                    {
                        cart.Add(product);
                    }
                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);
                }
                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}
