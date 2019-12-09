namespace CrmUI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtProduct = new System.Windows.Forms.Button();
            this.BtSeller = new System.Windows.Forms.Button();
            this.BtSell = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.btModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtProduct
            // 
            this.BtProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtProduct.Location = new System.Drawing.Point(12, 12);
            this.BtProduct.Name = "BtProduct";
            this.BtProduct.Size = new System.Drawing.Size(223, 42);
            this.BtProduct.TabIndex = 0;
            this.BtProduct.Text = "Product";
            this.BtProduct.UseVisualStyleBackColor = false;
            this.BtProduct.Click += new System.EventHandler(this.BtProduct_Click);
            // 
            // BtSeller
            // 
            this.BtSeller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSeller.Location = new System.Drawing.Point(12, 78);
            this.BtSeller.Name = "BtSeller";
            this.BtSeller.Size = new System.Drawing.Size(223, 42);
            this.BtSeller.TabIndex = 1;
            this.BtSeller.Text = "Seller";
            this.BtSeller.UseVisualStyleBackColor = false;
            this.BtSeller.Click += new System.EventHandler(this.BtSeller_Click);
            // 
            // BtSell
            // 
            this.BtSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSell.Location = new System.Drawing.Point(12, 141);
            this.BtSell.Name = "BtSell";
            this.BtSell.Size = new System.Drawing.Size(223, 42);
            this.BtSell.TabIndex = 2;
            this.BtSell.Text = "Sell";
            this.BtSell.UseVisualStyleBackColor = false;
            this.BtSell.Click += new System.EventHandler(this.BtSell_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCustomer.Location = new System.Drawing.Point(12, 207);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(223, 42);
            this.btCustomer.TabIndex = 3;
            this.btCustomer.Text = "Customer";
            this.btCustomer.UseVisualStyleBackColor = false;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btCheck
            // 
            this.btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheck.Location = new System.Drawing.Point(12, 276);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(223, 42);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btModel
            // 
            this.btModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btModel.Location = new System.Drawing.Point(12, 342);
            this.btModel.Name = "btModel";
            this.btModel.Size = new System.Drawing.Size(223, 42);
            this.btModel.TabIndex = 5;
            this.btModel.Text = "Model";
            this.btModel.UseVisualStyleBackColor = false;
            this.btModel.Click += new System.EventHandler(this.btModel_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 455);
            this.Controls.Add(this.btModel);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.BtSell);
            this.Controls.Add(this.BtSeller);
            this.Controls.Add(this.BtProduct);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtProduct;
        private System.Windows.Forms.Button BtSeller;
        private System.Windows.Forms.Button BtSell;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btModel;
    }
}

