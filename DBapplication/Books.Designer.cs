namespace DatabaseProject
{
    partial class Books
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
            this.Booksgrid = new System.Windows.Forms.DataGridView();
            this.PurchaseBookbtn = new System.Windows.Forms.Button();
            this.borrowBooksbtn = new System.Windows.Forms.Button();
            this.Priceboxtxt = new System.Windows.Forms.TextBox();
            this.DiscountedPricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Voucherbox = new System.Windows.Forms.TextBox();
            this.Voucherbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Booksgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Booksgrid
            // 
            this.Booksgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Booksgrid.Location = new System.Drawing.Point(-1, -1);
            this.Booksgrid.Name = "Booksgrid";
            this.Booksgrid.RowHeadersWidth = 51;
            this.Booksgrid.RowTemplate.Height = 29;
            this.Booksgrid.Size = new System.Drawing.Size(629, 286);
            this.Booksgrid.TabIndex = 0;
            this.Booksgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Booksgrid_CellClick);
            // 
            // PurchaseBookbtn
            // 
            this.PurchaseBookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.PurchaseBookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PurchaseBookbtn.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchaseBookbtn.Location = new System.Drawing.Point(594, 318);
            this.PurchaseBookbtn.Name = "PurchaseBookbtn";
            this.PurchaseBookbtn.Size = new System.Drawing.Size(157, 52);
            this.PurchaseBookbtn.TabIndex = 1;
            this.PurchaseBookbtn.Text = "Purchase Book";
            this.PurchaseBookbtn.UseVisualStyleBackColor = false;
            this.PurchaseBookbtn.Click += new System.EventHandler(this.PurchaseBookbtn_Click);
            // 
            // borrowBooksbtn
            // 
            this.borrowBooksbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.borrowBooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowBooksbtn.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrowBooksbtn.Location = new System.Drawing.Point(594, 386);
            this.borrowBooksbtn.Name = "borrowBooksbtn";
            this.borrowBooksbtn.Size = new System.Drawing.Size(157, 51);
            this.borrowBooksbtn.TabIndex = 2;
            this.borrowBooksbtn.Text = "Borrow Book";
            this.borrowBooksbtn.UseVisualStyleBackColor = false;
            this.borrowBooksbtn.Click += new System.EventHandler(this.borrowBooksbtn_Click);
            // 
            // Priceboxtxt
            // 
            this.Priceboxtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Priceboxtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Priceboxtxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Priceboxtxt.Location = new System.Drawing.Point(94, 302);
            this.Priceboxtxt.Name = "Priceboxtxt";
            this.Priceboxtxt.Size = new System.Drawing.Size(125, 24);
            this.Priceboxtxt.TabIndex = 3;
            // 
            // DiscountedPricetxt
            // 
            this.DiscountedPricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.DiscountedPricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountedPricetxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountedPricetxt.Location = new System.Drawing.Point(277, 414);
            this.DiscountedPricetxt.Name = "DiscountedPricetxt";
            this.DiscountedPricetxt.Size = new System.Drawing.Size(125, 24);
            this.DiscountedPricetxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price after discount:";
            // 
            // Voucherbox
            // 
            this.Voucherbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Voucherbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Voucherbox.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Voucherbox.Location = new System.Drawing.Point(177, 359);
            this.Voucherbox.Name = "Voucherbox";
            this.Voucherbox.Size = new System.Drawing.Size(125, 24);
            this.Voucherbox.TabIndex = 7;
            // 
            // Voucherbtn
            // 
            this.Voucherbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Voucherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Voucherbtn.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Voucherbtn.Location = new System.Drawing.Point(319, 347);
            this.Voucherbtn.Name = "Voucherbtn";
            this.Voucherbtn.Size = new System.Drawing.Size(157, 51);
            this.Voucherbtn.TabIndex = 8;
            this.Voucherbtn.Text = "Enter Voucher code";
            this.Voucherbtn.UseVisualStyleBackColor = false;
            this.Voucherbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Voucher Code:";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Voucherbtn);
            this.Controls.Add(this.Voucherbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscountedPricetxt);
            this.Controls.Add(this.Priceboxtxt);
            this.Controls.Add(this.borrowBooksbtn);
            this.Controls.Add(this.PurchaseBookbtn);
            this.Controls.Add(this.Booksgrid);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Booksgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Booksgrid;
        private Button PurchaseBookbtn;
        private Button borrowBooksbtn;
        private TextBox Priceboxtxt;
        private TextBox DiscountedPricetxt;
        private Label label1;
        private Label label2;
        private TextBox Voucherbox;
        private Button Voucherbtn;
        private Label label3;
    }
}