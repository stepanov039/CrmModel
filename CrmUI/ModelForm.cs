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
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();
        public ModelForm()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {

            var cashDesks = new List<CashDeckView>();

            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var cashDesk = new CashDeckView(model.CashDesks[i], i, 10, 26 * i);
                cashDesks.Add(cashDesk);
                Controls.Add(cashDesk.CashDeskName);
                Controls.Add(cashDesk.Price);
                Controls.Add(cashDesk.QueueLenght);
                Controls.Add(cashDesk.ExitCustomer);

            }
            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            nUDCashDeskSpeed.Value = model.CashDeskSpeed;
            nUDCustomerSpeed.Value = model.CustomerSpeed;

        }

        private void nUDCustomerSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)nUDCustomerSpeed.Value;
        }

        private void nUDCashDeskSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)nUDCashDeskSpeed.Value;
        }
    }
}
