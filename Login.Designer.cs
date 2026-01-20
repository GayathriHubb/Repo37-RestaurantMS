namespace RestaurantMS
{
    partial class FormLogin
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
            this.LbHeading = new System.Windows.Forms.Label();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.LbPswrd = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.LavenderBlush;
            this.LbHeading.Location = new System.Drawing.Point(213, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(452, 44);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "CUISINE VEG RESTAURANT";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.PnlLogin.Controls.Add(this.label2);
            this.PnlLogin.Controls.Add(this.LbNoAcc);
            this.PnlLogin.Controls.Add(this.BtnRegister);
            this.PnlLogin.Controls.Add(this.BtnClear);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.ChkBxPswrd);
            this.PnlLogin.Controls.Add(this.TxtBxPswrd);
            this.PnlLogin.Controls.Add(this.TxtBxUsername);
            this.PnlLogin.Controls.Add(this.LbPswrd);
            this.PnlLogin.Controls.Add(this.LbUsername);
            this.PnlLogin.Location = new System.Drawing.Point(39, 100);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(800, 500);
            this.PnlLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(335, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "SIGN IN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.LbNoAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbNoAcc.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbNoAcc.Location = new System.Drawing.Point(302, 385);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(193, 23);
            this.LbNoAcc.TabIndex = 18;
            this.LbNoAcc.Text = "No Account Yet ?";
            this.LbNoAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.BtnRegister.Location = new System.Drawing.Point(271, 420);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(250, 50);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "REGISTER";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.BtnClear.Location = new System.Drawing.Point(438, 265);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 45);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.BtnLogin.Location = new System.Drawing.Point(197, 265);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 45);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "SIGN IN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ChkBxPswrd.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.ForeColor = System.Drawing.Color.FloralWhite;
            this.ChkBxPswrd.Location = new System.Drawing.Point(438, 180);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(182, 25);
            this.ChkBxPswrd.TabIndex = 6;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = false;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(320, 124);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 34);
            this.TxtBxPswrd.TabIndex = 5;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(320, 76);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 34);
            this.TxtBxUsername.TabIndex = 4;
            // 
            // LbPswrd
            // 
            this.LbPswrd.AutoSize = true;
            this.LbPswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.LbPswrd.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPswrd.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbPswrd.Location = new System.Drawing.Point(186, 130);
            this.LbPswrd.Name = "LbPswrd";
            this.LbPswrd.Size = new System.Drawing.Size(111, 23);
            this.LbPswrd.TabIndex = 12;
            this.LbPswrd.Text = "Password";
            this.LbPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.LbUsername.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbUsername.Location = new System.Drawing.Point(181, 82);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(116, 23);
            this.LbUsername.TabIndex = 10;
            this.LbUsername.Text = "Username";
            this.LbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Label LbPswrd;
        private System.Windows.Forms.Label LbUsername;
    }
}