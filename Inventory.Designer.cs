namespace RestaurantMS
{
    partial class FormInventory
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
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.BtnImage = new System.Windows.Forms.Button();
            this.PnlPhoto = new System.Windows.Forms.Panel();
            this.PicBxProd = new System.Windows.Forms.PictureBox();
            this.TxtBxStock = new System.Windows.Forms.TextBox();
            this.TxtBxPrice = new System.Windows.Forms.TextBox();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.TxtBxProdName = new System.Windows.Forms.TextBox();
            this.CmbBxCategory = new System.Windows.Forms.ComboBox();
            this.TxtBxProdId = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Pnl1.SuspendLayout();
            this.PnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxProd)).BeginInit();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbHeading.Location = new System.Drawing.Point(432, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(115, 25);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "INVENTORY";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl1.Controls.Add(this.BtnImage);
            this.Pnl1.Controls.Add(this.PnlPhoto);
            this.Pnl1.Controls.Add(this.TxtBxStock);
            this.Pnl1.Controls.Add(this.TxtBxPrice);
            this.Pnl1.Controls.Add(this.CmbBxStatus);
            this.Pnl1.Controls.Add(this.TxtBxProdName);
            this.Pnl1.Controls.Add(this.CmbBxCategory);
            this.Pnl1.Controls.Add(this.TxtBxProdId);
            this.Pnl1.Controls.Add(this.BtnClear);
            this.Pnl1.Controls.Add(this.BtnDelete);
            this.Pnl1.Controls.Add(this.BtnUpdate);
            this.Pnl1.Controls.Add(this.BtnInsert);
            this.Pnl1.Controls.Add(this.label6);
            this.Pnl1.Controls.Add(this.label5);
            this.Pnl1.Controls.Add(this.label4);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.label2);
            this.Pnl1.Controls.Add(this.Lb1);
            this.Pnl1.Location = new System.Drawing.Point(9, 40);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(960, 240);
            this.Pnl1.TabIndex = 3;
            // 
            // BtnImage
            // 
            this.BtnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImage.AutoSize = true;
            this.BtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImage.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnImage.Location = new System.Drawing.Point(760, 170);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(150, 40);
            this.BtnImage.TabIndex = 21;
            this.BtnImage.Text = "ITEM IMAGE";
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // PnlPhoto
            // 
            this.PnlPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPhoto.Controls.Add(this.PicBxProd);
            this.PnlPhoto.Location = new System.Drawing.Point(760, 12);
            this.PnlPhoto.Name = "PnlPhoto";
            this.PnlPhoto.Size = new System.Drawing.Size(150, 150);
            this.PnlPhoto.TabIndex = 7;
            // 
            // PicBxProd
            // 
            this.PicBxProd.BackColor = System.Drawing.Color.DimGray;
            this.PicBxProd.Location = new System.Drawing.Point(0, 0);
            this.PicBxProd.Name = "PicBxProd";
            this.PicBxProd.Size = new System.Drawing.Size(150, 150);
            this.PicBxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxProd.TabIndex = 0;
            this.PicBxProd.TabStop = false;
            // 
            // TxtBxStock
            // 
            this.TxtBxStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TxtBxStock.Location = new System.Drawing.Point(515, 64);
            this.TxtBxStock.Name = "TxtBxStock";
            this.TxtBxStock.Size = new System.Drawing.Size(200, 31);
            this.TxtBxStock.TabIndex = 20;
            // 
            // TxtBxPrice
            // 
            this.TxtBxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TxtBxPrice.Location = new System.Drawing.Point(515, 12);
            this.TxtBxPrice.Name = "TxtBxPrice";
            this.TxtBxPrice.Size = new System.Drawing.Size(200, 31);
            this.TxtBxPrice.TabIndex = 19;
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Available ",
            "Unavailable",
            "Deleted"});
            this.CmbBxStatus.Location = new System.Drawing.Point(515, 120);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(200, 33);
            this.CmbBxStatus.TabIndex = 18;
            // 
            // TxtBxProdName
            // 
            this.TxtBxProdName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TxtBxProdName.Location = new System.Drawing.Point(145, 69);
            this.TxtBxProdName.Name = "TxtBxProdName";
            this.TxtBxProdName.Size = new System.Drawing.Size(250, 31);
            this.TxtBxProdName.TabIndex = 15;
            // 
            // CmbBxCategory
            // 
            this.CmbBxCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CmbBxCategory.FormattingEnabled = true;
            this.CmbBxCategory.Items.AddRange(new object[] {
            "Available ",
            "Unavailable",
            "Deleted"});
            this.CmbBxCategory.Location = new System.Drawing.Point(145, 126);
            this.CmbBxCategory.Name = "CmbBxCategory";
            this.CmbBxCategory.Size = new System.Drawing.Size(200, 33);
            this.CmbBxCategory.TabIndex = 14;
            // 
            // TxtBxProdId
            // 
            this.TxtBxProdId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TxtBxProdId.Location = new System.Drawing.Point(145, 12);
            this.TxtBxProdId.Name = "TxtBxProdId";
            this.TxtBxProdId.Size = new System.Drawing.Size(200, 31);
            this.TxtBxProdId.TabIndex = 13;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnClear.Location = new System.Drawing.Point(515, 180);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(140, 40);
            this.BtnClear.TabIndex = 12;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnDelete.Location = new System.Drawing.Point(358, 182);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(140, 40);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnUpdate.Location = new System.Drawing.Point(197, 182);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(140, 40);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnInsert.Location = new System.Drawing.Point(40, 182);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(140, 40);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.Text = "INSERT";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(420, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price (₹)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(420, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(420, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold);
            this.Lb1.Location = new System.Drawing.Point(12, 18);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(96, 18);
            this.Lb1.TabIndex = 2;
            this.Lb1.Text = "Product Id";
            this.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl2
            // 
            this.Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl2.Controls.Add(this.DGVProducts);
            this.Pnl2.Controls.Add(this.label3);
            this.Pnl2.Location = new System.Drawing.Point(8, 290);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(960, 340);
            this.Pnl2.TabIndex = 4;
            // 
            // DGVProducts
            // 
            this.DGVProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProducts.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProducts.ColumnHeadersHeight = 34;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVProducts.EnableHeadersVisualStyles = false;
            this.DGVProducts.Location = new System.Drawing.Point(0, 40);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProducts.RowTemplate.Height = 28;
            this.DGVProducts.Size = new System.Drawing.Size(960, 290);
            this.DGVProducts.TabIndex = 6;
            this.DGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInventory_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "All Products";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "Image File";
            this.Ofd.Filter = "Image Files ( *.png, *.jpg, *.jpeg ) | *.png; *.jpg; *.jpeg;";
            this.Ofd.Title = "Select Product Image";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInventory";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Restaurant Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInventory_FormClosing);
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.PnlPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxProd)).EndInit();
            this.Pnl2.ResumeLayout(false);
            this.Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox CmbBxCategory;
        private System.Windows.Forms.TextBox TxtBxProdId;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private System.Windows.Forms.TextBox TxtBxProdName;
        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.Panel PnlPhoto;
        private System.Windows.Forms.PictureBox PicBxProd;
        private System.Windows.Forms.TextBox TxtBxStock;
        private System.Windows.Forms.TextBox TxtBxPrice;
        private System.Windows.Forms.OpenFileDialog Ofd;
    }
}