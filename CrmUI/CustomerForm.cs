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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            if (Customer != null)
            {
                tBName.Text = customer.Name;
            }
            
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            Customer.Name = tBName.Text;
            Close();
        }
    }
}
