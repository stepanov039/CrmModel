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
    public partial class Menu : Form
    {
        CrmContext db;
        public Menu()
        {
            InitializeComponent();
            db = new CrmContext();
        }
        private void BtProduct_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }
        private void BtSeller_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }
        private void BtSell_Click(object sender, EventArgs e)
        {
            var catalogSell = new Catalog<Sell>(db.Sells, db);
            catalogSell.Show();
        }
        private void btCustomer_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Check>(db.Checks, db);
            catalogProduct.Show();
        }

        private void btModel_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }
    }
}
