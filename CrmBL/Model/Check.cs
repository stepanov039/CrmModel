﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Check
    {
        public int CheckId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
        public DateTime Created { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return CheckId.ToString();
        }
    }
}
