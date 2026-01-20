namespace RestaurantMS
{
    partial class UCFoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPhoto = new System.Windows.Forms.Panel();
            this.PicBxFood = new System.Windows.Forms.PictureBox();
            this.LbProdName = new System.Windows.Forms.Label();
            this.LbP = new System.Windows.Forms.Label();
            this.LbS = new System.Windows.Forms.Label();
            this.LbQty = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NumUDQty = new System.Windows.Forms.NumericUpDown();
            this.LbStock = new System.Windows.Forms.Label();
            this.LbPrice = new System.Windows.Forms.Label();
            this.PnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDQty)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPhoto
            // 
            this.PnlPhoto.Controls.Add(this.PicBxFood);
            this.PnlPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPhoto.Location = new System.Drawing.Point(0, 0);
            this.PnlPhoto.Name = "PnlPhoto";
            this.PnlPhoto.Size = new System.Drawing.Size(200, 200);
            this.PnlPhoto.TabIndex = 0;
            // 
            // PicBxFood
            // 
            this.PicBxFood.BackColor = System.Drawing.Color.DimGray;
            this.PicBxFood.Location = new System.Drawing.Point(0, 0);
            this.PicBxFood.Name = "PicBxFood";
            this.PicBxFood.Size = new System.Drawing.Size(200, 200);
            this.PicBxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxFood.TabIndex = 0;
            this.PicBxFood.TabStop = false;
            // 
            // LbProdName
            // 
            this.LbProdName.AutoSize = true;
            this.LbProdName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.LbProdName.Location = new System.Drawing.Point(2, 205);
            this.LbProdName.Name = "LbProdName";
            this.LbProdName.Size = new System.Drawing.Size(148, 28);
            this.LbProdName.TabIndex = 2;
            this.LbProdName.Text = "Product Name";
            this.LbProdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbP
            // 
            this.LbP.AutoSize = true;
            this.LbP.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbP.Location = new System.Drawing.Point(5, 267);
            this.LbP.Name = "LbP";
            this.LbP.Size = new System.Drawing.Size(65, 21);
            this.LbP.TabIndex = 3;
            this.LbP.Text = "Price(₹)";
            this.LbP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbS
            // 
            this.LbS.AutoSize = true;
            this.LbS.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbS.Location = new System.Drawing.Point(5, 240);
            this.LbS.Name = "LbS";
            this.LbS.Size = new System.Drawing.Size(51, 21);
            this.LbS.TabIndex = 4;
            this.LbS.Text = "Stock";
            this.LbS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbQty
            // 
            this.LbQty.AutoSize = true;
            this.LbQty.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQty.Location = new System.Drawing.Point(3, 305);
            this.LbQty.Name = "LbQty";
            this.LbQty.Size = new System.Drawing.Size(36, 21);
            this.LbQty.TabIndex = 5;
            this.LbQty.Text = "Qty";
            this.LbQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnAdd.Location = new System.Drawing.Point(125, 301);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 33);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NumUDQty
            // 
            this.NumUDQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUDQty.Location = new System.Drawing.Point(39, 301);
            this.NumUDQty.Name = "NumUDQty";
            this.NumUDQty.Size = new System.Drawing.Size(80, 31);
            this.NumUDQty.TabIndex = 7;
            // 
            // LbStock
            // 
            this.LbStock.AutoSize = true;
            this.LbStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.LbStock.Location = new System.Drawing.Point(70, 238);
            this.LbStock.Name = "LbStock";
            this.LbStock.Size = new System.Drawing.Size(59, 25);
            this.LbStock.TabIndex = 9;
            this.LbStock.Text = "Stock";
            this.LbStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPrice
            // 
            this.LbPrice.AutoSize = true;
            this.LbPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.LbPrice.Location = new System.Drawing.Point(70, 265);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(54, 25);
            this.LbPrice.TabIndex = 8;
            this.LbPrice.Text = "Price";
            this.LbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.LbP);
            this.Controls.Add(this.LbStock);
            this.Controls.Add(this.NumUDQty);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LbQty);
            this.Controls.Add(this.LbS);
            this.Controls.Add(this.LbProdName);
            this.Controls.Add(this.PnlPhoto);
            this.Name = "UCFoodCard";
            this.Size = new System.Drawing.Size(200, 350);
            this.PnlPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlPhoto;
        private System.Windows.Forms.Label LbProdName;
        private System.Windows.Forms.Label LbP;
        private System.Windows.Forms.Label LbS;
        private System.Windows.Forms.Label LbQty;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NumUDQty;
        private System.Windows.Forms.PictureBox PicBxFood;
        private System.Windows.Forms.Label LbStock;
        private System.Windows.Forms.Label LbPrice;
    }
}
