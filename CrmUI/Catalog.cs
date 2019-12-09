using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        CrmContext db;
        DbSet<T> set;
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.set = set;
            set.Load();
            DGVCatalog.DataSource = set.Local.ToBindingList();
            this.db = db;
        }
        //TODO: пределать на более унирсальное
        private void btAdd_Click(object sender, EventArgs e)
        {

            if (typeof(T) == typeof(Product))
            {
                Product = new Product();
                var Form = new ProductForm(Product);
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.Products.Add(Form.Product);
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                Customer = new Customer();
                var Form = new CustomerForm(Customer);
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.Customers.Add(Form.Customer);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
            db.SaveChanges();
        }
        //TODO: пределать на более унирсальное
        private void btUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DGVCatalog.SelectedRows[0].Cells[0].Value);

            if (typeof(T) == typeof(Product))
            {
                Product = db.Products.Find(id);
                var Form = new ProductForm(Product);
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                Customer = db.Customers.Find(id);
                var Form = new CustomerForm(Customer);
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
