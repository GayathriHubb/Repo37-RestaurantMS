namespace RestaurantMS
{
    partial class FormCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.TxtBxCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnDelete);
            this.Pnl1.Controls.Add(this.BtnUpdate);
            this.Pnl1.Controls.Add(this.BtnInsert);
            this.Pnl1.Controls.Add(this.CmbBxStatus);
            this.Pnl1.Controls.Add(this.TxtBxCategory);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.Lb1);
            this.Pnl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl1.Location = new System.Drawing.Point(9, 40);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(960, 200);
            this.Pnl1.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnClear.Location = new System.Drawing.Point(721, 111);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 45);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnDelete.Location = new System.Drawing.Point(556, 113);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 45);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnUpdate.Location = new System.Drawing.Point(721, 35);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 45);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnInsert.Location = new System.Drawing.Point(556, 35);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(150, 45);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "INSERT";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Available ",
            "Unavailable"});
            this.CmbBxStatus.Location = new System.Drawing.Point(160, 106);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(200, 36);
            this.CmbBxStatus.TabIndex = 6;
            // 
            // TxtBxCategory
            // 
            this.TxtBxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCategory.Location = new System.Drawing.Point(160, 40);
            this.TxtBxCategory.Name = "TxtBxCategory";
            this.TxtBxCategory.Size = new System.Drawing.Size(300, 34);
            this.TxtBxCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.Lb1.Location = new System.Drawing.Point(25, 49);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(106, 23);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Category";
            this.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbHeading.Location = new System.Drawing.Point(438, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(121, 25);
            this.LbHeading.TabIndex = 1;
            this.LbHeading.Text = "CATEGORIES";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl2.Controls.Add(this.DGVCategories);
            this.Pnl2.Controls.Add(this.label1);
            this.Pnl2.Location = new System.Drawing.Point(8, 250);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(960, 380);
            this.Pnl2.TabIndex = 1;
            // 
            // DGVCategories
            // 
            this.DGVCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategories.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategories.ColumnHeadersHeight = 34;
            this.DGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCategories.EnableHeadersVisualStyles = false;
            this.DGVCategories.Location = new System.Drawing.Point(0, 40);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategories.RowTemplate.Height = 28;
            this.DGVCategories.Size = new System.Drawing.Size(960, 330);
            this.DGVCategories.TabIndex = 3;
            this.DGVCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategories_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCategories";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Restaurant Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCategories_FormClosing);
            this.Load += new System.EventHandler(this.FormCategories_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.TextBox TxtBxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVCategories;
    }
}