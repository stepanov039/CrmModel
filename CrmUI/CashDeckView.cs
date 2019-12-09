using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    class CashDeckView
    {
        CashDesk cashDesk;
        public Label CashDeskName { get; set; }
        public Label ExitCustomer { get; set; }
        public NumericUpDown Price { get; set; }
        public ProgressBar QueueLenght { get; set; }
        public CashDeckView(CashDesk cashDesk, int number, int x, int y)
        {

            this.cashDesk = cashDesk;
            // label1
            // 
            CashDeskName = new Label();
            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(x, y + 10);
            CashDeskName.Name = "CashDeskName" + number;
            CashDeskName.Size = new System.Drawing.Size(35, 11);
            CashDeskName.TabIndex = 1;
            CashDeskName.Text = cashDesk.ToString();
            // 


            // label1
            // 
            ExitCustomer = new Label();
            ExitCustomer.AutoSize = true;
            ExitCustomer.Location = new System.Drawing.Point(x + 420, y + 10);
            ExitCustomer.Name = "ExitCustomer" + number;
            ExitCustomer.Size = new System.Drawing.Size(35, 11);
            ExitCustomer.TabIndex = 1;
            ExitCustomer.Text = cashDesk.ToString();

            // numericUpDown1
            // 

            Price = new NumericUpDown();
            Price.Location = new System.Drawing.Point(x + 100, y + 10);
            Price.Name = "Price" + number;
            Price.Size = new System.Drawing.Size(120, 40);
            Price.TabIndex = 3;
            Price.Maximum = 100000000000000000;

            QueueLenght = new ProgressBar();
            QueueLenght.Maximum = cashDesk.MaxQueueLenght;
            QueueLenght.Value = 0;
            QueueLenght.Location = new System.Drawing.Point(x + 250, y + 10);
            QueueLenght.Name = "QueueLenght" + number;
            QueueLenght.Size = new System.Drawing.Size(165, 23);
            QueueLenght.TabIndex = 1;


            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            Price.Invoke((Action)delegate { 
                Price.Value += e.Price;
                QueueLenght.Value = cashDesk.Count;
                ExitCustomer.Text = cashDesk.ExitCustomer.ToString();
            });
          //  QueueLenght.Invoke((Action)delegate { QueueLenght.Value = ((CashDesk)sender).Count; });
        }
    }
}
