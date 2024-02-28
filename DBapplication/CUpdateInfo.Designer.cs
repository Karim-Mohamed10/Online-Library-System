namespace DatabaseProject
{
    partial class CUpdateInfo
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
            this.Updateinfobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Genderbox = new System.Windows.Forms.ComboBox();
            this.Agebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Updateinfobtn
            // 
            this.Updateinfobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Updateinfobtn.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updateinfobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Updateinfobtn.Location = new System.Drawing.Point(314, 317);
            this.Updateinfobtn.Name = "Updateinfobtn";
            this.Updateinfobtn.Size = new System.Drawing.Size(185, 50);
            this.Updateinfobtn.TabIndex = 0;
            this.Updateinfobtn.Text = "Save changes";
            this.Updateinfobtn.UseVisualStyleBackColor = false;
            this.Updateinfobtn.Click += new System.EventHandler(this.Updateinfobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(54, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(68, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // Genderbox
            // 
            this.Genderbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Genderbox.FormattingEnabled = true;
            this.Genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Genderbox.Location = new System.Drawing.Point(183, 122);
            this.Genderbox.Name = "Genderbox";
            this.Genderbox.Size = new System.Drawing.Size(151, 28);
            this.Genderbox.TabIndex = 3;
            // 
            // Agebox
            // 
            this.Agebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Agebox.Location = new System.Drawing.Point(183, 189);
            this.Agebox.Name = "Agebox";
            this.Agebox.Size = new System.Drawing.Size(151, 27);
            this.Agebox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Update info";
            // 
            // Phonetxt
            // 
            this.Phonetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Phonetxt.Location = new System.Drawing.Point(183, 249);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(151, 27);
            this.Phonetxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(17, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // CUpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Agebox);
            this.Controls.Add(this.Genderbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Updateinfobtn);
            this.Name = "CUpdateInfo";
            this.Text = "CUpdateInfo";
            this.Load += new System.EventHandler(this.CUpdateInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Updateinfobtn;
        private Label label1;
        private Label label2;
        private ComboBox Genderbox;
        private TextBox Agebox;
        private Label label3;
        private TextBox Phonetxt;
        private Label label4;
    }
}