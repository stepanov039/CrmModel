using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class CashDesk
    {
        CrmContext db = new CrmContext();
        public int Number { get; set; }
        public Seller Seller { get; set; }
        public Queue<Cart> Queue { get; set; }
        public int MaxQueueLenght { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public event EventHandler<Check> CheckClosed;
        public CashDesk(int number, Seller seller)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
            MaxQueueLenght = 10;
        }
        public void Enqueue(Cart cart)
        {
            if (Queue.Count < MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }
        public decimal Dequeue()
        {
            var cart = Queue.Dequeue();
            if (Queue.Count == 0)
            { 
                return 0;
            }
            decimal sum = 0;
            if (cart != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    Customer = cart.Customer,
                    CustomerId = cart.Customer.CustomerId,
                    Created = DateTime.UtcNow
                };
                if (!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                };
                var sells = new List<Sell>();
                foreach (Product product in cart)
                {
                    var sell = new Sell()
                    {
                        CheckId = check.CheckId,
                        Check = check,
                        ProductId = product.ProductId,
                        Product = product
                    };
                    product.Count--;
                    sum += product.Price;
                    sells.Add(sell);
                }
                check.Price = sum;

                if (!IsModel)
                {
                    db.Sells.AddRange(sells);
                    db.SaveChanges();
                }

                CheckClosed?.Invoke(this, check);
            }
            
            return sum;
        }
        public override string ToString()
        {
            return "cashdesk" + Number;
        }
    }
}
