namespace DatabaseProject
{
    partial class CustomerSignIn
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
            this.UserIDtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Signinbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visiblepassbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIDtxt
            // 
            this.UserIDtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.UserIDtxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserIDtxt.Location = new System.Drawing.Point(531, 134);
            this.UserIDtxt.Name = "UserIDtxt";
            this.UserIDtxt.Size = new System.Drawing.Size(208, 31);
            this.UserIDtxt.TabIndex = 0;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.passtxt.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passtxt.Location = new System.Drawing.Point(531, 240);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(207, 31);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(354, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username(ID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(373, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(542, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign in";
            // 
            // Signinbtn
            // 
            this.Signinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.Signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signinbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Signinbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Signinbtn.Location = new System.Drawing.Point(512, 355);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(116, 29);
            this.Signinbtn.TabIndex = 6;
            this.Signinbtn.Text = "Sign In";
            this.Signinbtn.UseVisualStyleBackColor = false;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 457);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // visiblepassbtn
            // 
            this.visiblepassbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.visiblepassbtn.BackgroundImage = global::DatabaseProject.Properties.Resources.eye_password;
            this.visiblepassbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visiblepassbtn.Location = new System.Drawing.Point(753, 242);
            this.visiblepassbtn.Name = "visiblepassbtn";
            this.visiblepassbtn.Size = new System.Drawing.Size(35, 29);
            this.visiblepassbtn.TabIndex = 23;
            this.visiblepassbtn.UseVisualStyleBackColor = false;
            this.visiblepassbtn.Click += new System.EventHandler(this.visiblepassbtn_Click);
            // 
            // CustomerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visiblepassbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Signinbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.UserIDtxt);
            this.Name = "CustomerSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserIDtxt;
        private TextBox passtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Signinbtn;
        private PictureBox pictureBox1;
        private Button visiblepassbtn;
    }
}