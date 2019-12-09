using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        
        public ProductForm(Product product)
        {
            InitializeComponent();
            Product = product;
            if (Product != null)
            {
                tBName.Text = product.Name;
                nUpDPrice.Value = product.Price;
                nUpDCount.Value = product.Count;
            }            
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            Product.Name = tBName.Text;
            Product.Price = nUpDPrice.Value;
            Product.Count = (int)nUpDCount.Value;
            Close();
        }
    }
}
