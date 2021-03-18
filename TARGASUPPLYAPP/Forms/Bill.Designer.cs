
namespace TARGASUPPLYAPP.Forms
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.txtBillingAdress = new System.Windows.Forms.RichTextBox();
            this.txtBillDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.txtBillClock = new System.Windows.Forms.RichTextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.RichTextBox();
            this.labelNumberofProduct = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.RichTextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelHW = new System.Windows.Forms.Label();
            this.txtAllCostHW = new System.Windows.Forms.RichTextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.downPanel = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(65, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Müşteri Ad-Soyad";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Location = new System.Drawing.Point(29, 61);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 39);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(65, 118);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(101, 16);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Fatura Adresi";
            // 
            // txtBillingAdress
            // 
            this.txtBillingAdress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBillingAdress.Location = new System.Drawing.Point(29, 137);
            this.txtBillingAdress.Name = "txtBillingAdress";
            this.txtBillingAdress.Size = new System.Drawing.Size(231, 111);
            this.txtBillingAdress.TabIndex = 4;
            this.txtBillingAdress.Text = "";
            this.txtBillingAdress.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtBillDate
            // 
            this.txtBillDate.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.txtBillDate.CustomFormat = "dd.MM.yyyy";
            this.txtBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBillDate.Location = new System.Drawing.Point(29, 286);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(200, 20);
            this.txtBillDate.TabIndex = 6;
            this.txtBillDate.Value = new System.DateTime(2021, 3, 9, 23, 3, 6, 0);
            this.txtBillDate.ValueChanged += new System.EventHandler(this.txtBillDate_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(65, 267);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(92, 16);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Fatura Tarih";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(323, 30);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(133, 16);
            this.labelClock.TabIndex = 8;
            this.labelClock.Text = "Düzenlenme Saati";
            // 
            // txtBillClock
            // 
            this.txtBillClock.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBillClock.Location = new System.Drawing.Point(292, 61);
            this.txtBillClock.Name = "txtBillClock";
            this.txtBillClock.Size = new System.Drawing.Size(232, 39);
            this.txtBillClock.TabIndex = 9;
            this.txtBillClock.Text = "";
            this.txtBillClock.TextChanged += new System.EventHandler(this.txtBillClock_TextChanged);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(323, 117);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(67, 16);
            this.labelProductName.TabIndex = 11;
            this.labelProductName.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProductName.Location = new System.Drawing.Point(292, 136);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 39);
            this.txtProductName.TabIndex = 12;
            this.txtProductName.Text = "";
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // labelNumberofProduct
            // 
            this.labelNumberofProduct.AutoSize = true;
            this.labelNumberofProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberofProduct.Location = new System.Drawing.Point(323, 189);
            this.labelNumberofProduct.Name = "labelNumberofProduct";
            this.labelNumberofProduct.Size = new System.Drawing.Size(85, 16);
            this.labelNumberofProduct.TabIndex = 14;
            this.labelNumberofProduct.Text = "Ürün Adedi";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuantity.Location = new System.Drawing.Point(292, 208);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 39);
            this.txtQuantity.TabIndex = 15;
            this.txtQuantity.Text = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.Location = new System.Drawing.Point(323, 267);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(82, 16);
            this.labelProductPrice.TabIndex = 16;
            this.labelProductPrice.Text = "Ürün Fiyatı";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPrice.Location = new System.Drawing.Point(292, 286);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 37);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.Text = "";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButton3);
            this.panel7.Controls.Add(this.radioButton2);
            this.panel7.Controls.Add(this.radioButton1);
            this.panel7.Location = new System.Drawing.Point(558, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(176, 131);
            this.panel7.TabIndex = 19;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton3.BackgroundImage")));
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton3.Location = new System.Drawing.Point(0, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 18);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "       ";
            this.radioButton3.UseCompatibleTextRendering = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton2.BackgroundImage")));
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton2.Location = new System.Drawing.Point(0, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "       ";
            this.radioButton2.UseCompatibleTextRendering = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton1.Location = new System.Drawing.Point(0, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "       ";
            this.radioButton1.UseCompatibleTextRendering = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelHW
            // 
            this.labelHW.AutoSize = true;
            this.labelHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHW.Location = new System.Drawing.Point(575, 219);
            this.labelHW.Name = "labelHW";
            this.labelHW.Size = new System.Drawing.Size(99, 16);
            this.labelHW.TabIndex = 20;
            this.labelHW.Text = "Tutar Yazı İle";
            this.labelHW.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAllCostHW
            // 
            this.txtAllCostHW.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAllCostHW.Location = new System.Drawing.Point(558, 238);
            this.txtAllCostHW.Name = "txtAllCostHW";
            this.txtAllCostHW.Size = new System.Drawing.Size(220, 85);
            this.txtAllCostHW.TabIndex = 21;
            this.txtAllCostHW.Text = "";
            this.txtAllCostHW.TextChanged += new System.EventHandler(this.txtAllCostHW_TextChanged);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(575, 42);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(113, 16);
            this.labelTax.TabIndex = 22;
            this.labelTax.Text = "Vergi Oranı (%)";
            // 
            // sendButton
            // 
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.Location = new System.Drawing.Point(926, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 51);
            this.sendButton.TabIndex = 23;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // downPanel
            // 
            this.downPanel.Controls.Add(this.sendButton);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 399);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(1004, 51);
            this.downPanel.TabIndex = 24;
            this.downPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Bill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.txtAllCostHW);
            this.Controls.Add(this.labelHW);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.labelNumberofProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.txtBillClock);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.txtBillDate);
            this.Controls.Add(this.txtBillingAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.RichTextBox txtBillingAdress;
        private System.Windows.Forms.DateTimePicker txtBillDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.RichTextBox txtBillClock;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.RichTextBox txtProductName;
        private System.Windows.Forms.Label labelNumberofProduct;
        private System.Windows.Forms.RichTextBox txtQuantity;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.RichTextBox txtPrice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelHW;
        private System.Windows.Forms.RichTextBox txtAllCostHW;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel downPanel;
    }
}