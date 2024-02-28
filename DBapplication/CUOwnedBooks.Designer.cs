namespace DatabaseProject
{
    partial class CUOwnedBooks
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
            this.OwnedBooksgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BorrowedBooksgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OwnedBooksgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedBooksgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnedBooksgrid
            // 
            this.OwnedBooksgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwnedBooksgrid.Location = new System.Drawing.Point(12, 60);
            this.OwnedBooksgrid.Name = "OwnedBooksgrid";
            this.OwnedBooksgrid.RowHeadersWidth = 51;
            this.OwnedBooksgrid.RowTemplate.Height = 29;
            this.OwnedBooksgrid.Size = new System.Drawing.Size(338, 378);
            this.OwnedBooksgrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchased Books:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(443, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borrowed Books:";
            // 
            // BorrowedBooksgrid
            // 
            this.BorrowedBooksgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowedBooksgrid.Location = new System.Drawing.Point(443, 60);
            this.BorrowedBooksgrid.Name = "BorrowedBooksgrid";
            this.BorrowedBooksgrid.RowHeadersWidth = 51;
            this.BorrowedBooksgrid.RowTemplate.Height = 29;
            this.BorrowedBooksgrid.Size = new System.Drawing.Size(338, 378);
            this.BorrowedBooksgrid.TabIndex = 4;
            // 
            // CUOwnedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BorrowedBooksgrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwnedBooksgrid);
            this.Name = "CUOwnedBooks";
            this.Text = "CUOwnedBooks";
            this.Load += new System.EventHandler(this.CUOwnedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OwnedBooksgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedBooksgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView OwnedBooksgrid;
        private Label label1;
        private Label label2;
        private DataGridView BorrowedBooksgrid;
    }
}