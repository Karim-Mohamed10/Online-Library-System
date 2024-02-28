namespace DatabaseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Libbtn = new System.Windows.Forms.Button();
            this.Custbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Authorbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Libbtn
            // 
            this.Libbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Libbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Libbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Libbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Libbtn.Location = new System.Drawing.Point(508, 325);
            this.Libbtn.Name = "Libbtn";
            this.Libbtn.Size = new System.Drawing.Size(234, 64);
            this.Libbtn.TabIndex = 1;
            this.Libbtn.Text = "Librarian";
            this.Libbtn.UseVisualStyleBackColor = false;
            // 
            // Custbtn
            // 
            this.Custbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Custbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Custbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Custbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Custbtn.Location = new System.Drawing.Point(508, 156);
            this.Custbtn.Name = "Custbtn";
            this.Custbtn.Size = new System.Drawing.Size(234, 64);
            this.Custbtn.TabIndex = 5;
            this.Custbtn.Text = "Customer";
            this.Custbtn.UseVisualStyleBackColor = false;
            this.Custbtn.Click += new System.EventHandler(this.Custbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(477, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to OLS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(539, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sign in as";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.pictureBox1.BackgroundImage = global::DatabaseProject.Properties.Resources.online_library_system_high_resolution_logo__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 452);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Authorbtn
            // 
            this.Authorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Authorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Authorbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Authorbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Authorbtn.Location = new System.Drawing.Point(508, 238);
            this.Authorbtn.Name = "Authorbtn";
            this.Authorbtn.Size = new System.Drawing.Size(234, 64);
            this.Authorbtn.TabIndex = 12;
            this.Authorbtn.Text = "Author";
            this.Authorbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Authorbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Custbtn);
            this.Controls.Add(this.Libbtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Libbtn;
        private Button Custbtn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button Authorbtn;
    }
}