namespace CrmUI
{
    partial class ModelForm
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
            this.btStart = new System.Windows.Forms.Button();
            this.LbCustomerSpeed = new System.Windows.Forms.Label();
            this.lbCashDeskSpeed = new System.Windows.Forms.Label();
            this.nUDCustomerSpeed = new System.Windows.Forms.NumericUpDown();
            this.nUDCashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCustomerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCashDeskSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(653, 402);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(130, 36);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // LbCustomerSpeed
            // 
            this.LbCustomerSpeed.AutoSize = true;
            this.LbCustomerSpeed.Location = new System.Drawing.Point(522, 9);
            this.LbCustomerSpeed.Name = "LbCustomerSpeed";
            this.LbCustomerSpeed.Size = new System.Drawing.Size(105, 13);
            this.LbCustomerSpeed.TabIndex = 1;
            this.LbCustomerSpeed.Text = "Скорость клиентов";
            // 
            // lbCashDeskSpeed
            // 
            this.lbCashDeskSpeed.AutoSize = true;
            this.lbCashDeskSpeed.Location = new System.Drawing.Point(545, 41);
            this.lbCashDeskSpeed.Name = "lbCashDeskSpeed";
            this.lbCashDeskSpeed.Size = new System.Drawing.Size(82, 13);
            this.lbCashDeskSpeed.TabIndex = 2;
            this.lbCashDeskSpeed.Text = "Скорость касс";
            // 
            // nUDCustomerSpeed
            // 
            this.nUDCustomerSpeed.Location = new System.Drawing.Point(648, 7);
            this.nUDCustomerSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUDCustomerSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCustomerSpeed.Name = "nUDCustomerSpeed";
            this.nUDCustomerSpeed.Size = new System.Drawing.Size(135, 20);
            this.nUDCustomerSpeed.TabIndex = 3;
            this.nUDCustomerSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDCustomerSpeed.ValueChanged += new System.EventHandler(this.nUDCustomerSpeed_ValueChanged);
            // 
            // nUDCashDeskSpeed
            // 
            this.nUDCashDeskSpeed.Location = new System.Drawing.Point(648, 34);
            this.nUDCashDeskSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUDCashDeskSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCashDeskSpeed.Name = "nUDCashDeskSpeed";
            this.nUDCashDeskSpeed.Size = new System.Drawing.Size(135, 20);
            this.nUDCashDeskSpeed.TabIndex = 4;
            this.nUDCashDeskSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDCashDeskSpeed.ValueChanged += new System.EventHandler(this.nUDCashDeskSpeed_ValueChanged);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nUDCashDeskSpeed);
            this.Controls.Add(this.nUDCustomerSpeed);
            this.Controls.Add(this.lbCashDeskSpeed);
            this.Controls.Add(this.LbCustomerSpeed);
            this.Controls.Add(this.btStart);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCustomerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCashDeskSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label LbCustomerSpeed;
        private System.Windows.Forms.Label lbCashDeskSpeed;
        private System.Windows.Forms.NumericUpDown nUDCustomerSpeed;
        private System.Windows.Forms.NumericUpDown nUDCashDeskSpeed;
    }
}