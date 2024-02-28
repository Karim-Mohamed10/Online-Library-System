namespace DatabaseProject
{
    partial class Review
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBNcombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitreviewbtn = new System.Windows.Forms.Button();
            this.Ratingcombo = new System.Windows.Forms.ComboBox();
            this.Commenttxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Review";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(53, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rating";
            // 
            // ISBNcombo
            // 
            this.ISBNcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.ISBNcombo.FormattingEnabled = true;
            this.ISBNcombo.Location = new System.Drawing.Point(199, 131);
            this.ISBNcombo.Name = "ISBNcombo";
            this.ISBNcombo.Size = new System.Drawing.Size(151, 28);
            this.ISBNcombo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(34, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Book ISBN";
            // 
            // submitreviewbtn
            // 
            this.submitreviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.submitreviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitreviewbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitreviewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.submitreviewbtn.Location = new System.Drawing.Point(244, 308);
            this.submitreviewbtn.Name = "submitreviewbtn";
            this.submitreviewbtn.Size = new System.Drawing.Size(304, 75);
            this.submitreviewbtn.TabIndex = 15;
            this.submitreviewbtn.Text = "SUBMIT";
            this.submitreviewbtn.UseVisualStyleBackColor = false;
            this.submitreviewbtn.Click += new System.EventHandler(this.submitreviewbtn_Click);
            // 
            // Ratingcombo
            // 
            this.Ratingcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Ratingcombo.FormattingEnabled = true;
            this.Ratingcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Ratingcombo.Location = new System.Drawing.Point(199, 196);
            this.Ratingcombo.Name = "Ratingcombo";
            this.Ratingcombo.Size = new System.Drawing.Size(151, 28);
            this.Ratingcombo.TabIndex = 16;
            // 
            // Commenttxt
            // 
            this.Commenttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Commenttxt.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Commenttxt.Location = new System.Drawing.Point(199, 76);
            this.Commenttxt.Name = "Commenttxt";
            this.Commenttxt.Size = new System.Drawing.Size(151, 29);
            this.Commenttxt.TabIndex = 17;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Commenttxt);
            this.Controls.Add(this.Ratingcombo);
            this.Controls.Add(this.submitreviewbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ISBNcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox ISBNcombo;
        private Label label5;
        private Button submitreviewbtn;
        private ComboBox Ratingcombo;
        private TextBox Commenttxt;
    }
}