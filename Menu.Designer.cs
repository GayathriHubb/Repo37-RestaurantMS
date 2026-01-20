namespace RestaurantMS
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.LbHeading = new System.Windows.Forms.Label();
            this.FLPFood = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlOrder = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBxTenChng = new System.Windows.Forms.TextBox();
            this.TxtBxTenCash = new System.Windows.Forms.TextBox();
            this.TxtBxTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbTP = new System.Windows.Forms.Label();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.DGVOrders = new System.Windows.Forms.DataGridView();
            this.Col1CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbHeading.Location = new System.Drawing.Point(429, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(121, 25);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "FOOD ITEMS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FLPFood
            // 
            this.FLPFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPFood.AutoScroll = true;
            this.FLPFood.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.FLPFood.Location = new System.Drawing.Point(5, 40);
            this.FLPFood.Name = "FLPFood";
            this.FLPFood.Size = new System.Drawing.Size(450, 590);
            this.FLPFood.TabIndex = 3;
            // 
            // PnlOrder
            // 
            this.PnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlOrder.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PnlOrder.Controls.Add(this.BtnClear);
            this.PnlOrder.Controls.Add(this.BtnReceipt);
            this.PnlOrder.Controls.Add(this.label3);
            this.PnlOrder.Controls.Add(this.TxtBxTenChng);
            this.PnlOrder.Controls.Add(this.TxtBxTenCash);
            this.PnlOrder.Controls.Add(this.TxtBxTP);
            this.PnlOrder.Controls.Add(this.label2);
            this.PnlOrder.Controls.Add(this.label1);
            this.PnlOrder.Controls.Add(this.LbTP);
            this.PnlOrder.Controls.Add(this.BtnPlaceOrder);
            this.PnlOrder.Controls.Add(this.BtnRemove);
            this.PnlOrder.Controls.Add(this.DGVOrders);
            this.PnlOrder.Location = new System.Drawing.Point(460, 40);
            this.PnlOrder.Name = "PnlOrder";
            this.PnlOrder.Size = new System.Drawing.Size(510, 590);
            this.PnlOrder.TabIndex = 4;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnClear.Location = new System.Drawing.Point(282, 491);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(140, 40);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReceipt.AutoSize = true;
            this.BtnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnReceipt.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnReceipt.Location = new System.Drawing.Point(282, 537);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(140, 40);
            this.BtnReceipt.TabIndex = 15;
            this.BtnReceipt.Text = "RECEIPT";
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Orders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxTenChng
            // 
            this.TxtBxTenChng.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtBxTenChng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTenChng.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTenChng.Location = new System.Drawing.Point(214, 443);
            this.TxtBxTenChng.Name = "TxtBxTenChng";
            this.TxtBxTenChng.Size = new System.Drawing.Size(210, 31);
            this.TxtBxTenChng.TabIndex = 13;
            // 
            // TxtBxTenCash
            // 
            this.TxtBxTenCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtBxTenCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTenCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTenCash.Location = new System.Drawing.Point(214, 400);
            this.TxtBxTenCash.Name = "TxtBxTenCash";
            this.TxtBxTenCash.Size = new System.Drawing.Size(210, 31);
            this.TxtBxTenCash.TabIndex = 12;
            this.TxtBxTenCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxTenCash_KeyDown);
            // 
            // TxtBxTP
            // 
            this.TxtBxTP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtBxTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxTP.Location = new System.Drawing.Point(212, 357);
            this.TxtBxTP.Name = "TxtBxTP";
            this.TxtBxTP.Size = new System.Drawing.Size(210, 31);
            this.TxtBxTP.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Change (₹)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount (₹)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTP
            // 
            this.LbTP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbTP.AutoSize = true;
            this.LbTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTP.Location = new System.Drawing.Point(81, 356);
            this.LbTP.Name = "LbTP";
            this.LbTP.Size = new System.Drawing.Size(125, 25);
            this.LbTP.TabIndex = 8;
            this.LbTP.Text = "Total Price (₹)";
            this.LbTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPlaceOrder.AutoSize = true;
            this.BtnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnPlaceOrder.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnPlaceOrder.Location = new System.Drawing.Point(84, 537);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(144, 40);
            this.BtnPlaceOrder.TabIndex = 7;
            this.BtnPlaceOrder.Text = "PLACE ORDER";
            this.BtnPlaceOrder.UseVisualStyleBackColor = false;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnRemove.Location = new System.Drawing.Point(86, 491);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(140, 40);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "REMOVE";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // DGVOrders
            // 
            this.DGVOrders.AllowUserToAddRows = false;
            this.DGVOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVOrders.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVOrders.ColumnHeadersHeight = 34;
            this.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1CustId,
            this.Col2Id,
            this.Col3ProdId,
            this.Col4ProdName,
            this.Col5ProdQty,
            this.Col6ProdPrice,
            this.Col7Cat});
            this.DGVOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVOrders.EnableHeadersVisualStyles = false;
            this.DGVOrders.Location = new System.Drawing.Point(5, 40);
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVOrders.RowTemplate.Height = 28;
            this.DGVOrders.Size = new System.Drawing.Size(500, 290);
            this.DGVOrders.TabIndex = 3;
            this.DGVOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrders_CellClick);
            // 
            // Col1CustId
            // 
            this.Col1CustId.HeaderText = "CustId";
            this.Col1CustId.MinimumWidth = 8;
            this.Col1CustId.Name = "Col1CustId";
            this.Col1CustId.ReadOnly = true;
            this.Col1CustId.Width = 150;
            // 
            // Col2Id
            // 
            this.Col2Id.HeaderText = "Id";
            this.Col2Id.MinimumWidth = 8;
            this.Col2Id.Name = "Col2Id";
            this.Col2Id.ReadOnly = true;
            this.Col2Id.Width = 150;
            // 
            // Col3ProdId
            // 
            this.Col3ProdId.HeaderText = "ProdId";
            this.Col3ProdId.MinimumWidth = 8;
            this.Col3ProdId.Name = "Col3ProdId";
            this.Col3ProdId.ReadOnly = true;
            this.Col3ProdId.Width = 150;
            // 
            // Col4ProdName
            // 
            this.Col4ProdName.HeaderText = "ProdName";
            this.Col4ProdName.MinimumWidth = 8;
            this.Col4ProdName.Name = "Col4ProdName";
            this.Col4ProdName.ReadOnly = true;
            this.Col4ProdName.Width = 150;
            // 
            // Col5ProdQty
            // 
            this.Col5ProdQty.HeaderText = "ProdQty";
            this.Col5ProdQty.MinimumWidth = 8;
            this.Col5ProdQty.Name = "Col5ProdQty";
            this.Col5ProdQty.ReadOnly = true;
            this.Col5ProdQty.Width = 150;
            // 
            // Col6ProdPrice
            // 
            this.Col6ProdPrice.HeaderText = "ProdPrice";
            this.Col6ProdPrice.MinimumWidth = 8;
            this.Col6ProdPrice.Name = "Col6ProdPrice";
            this.Col6ProdPrice.ReadOnly = true;
            this.Col6ProdPrice.Width = 150;
            // 
            // Col7Cat
            // 
            this.Col7Cat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col7Cat.HeaderText = "Category";
            this.Col7Cat.MinimumWidth = 2;
            this.Col7Cat.Name = "Col7Cat";
            this.Col7Cat.ReadOnly = true;
            this.Col7Cat.Visible = false;
            this.Col7Cat.Width = 150;
            // 
            // PD1
            // 
            this.PD1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD1_PrintPage);
            // 
            // PPD1
            // 
            this.PPD1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD1.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD1.Document = this.PD1;
            this.PPD1.Enabled = true;
            this.PPD1.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD1.Icon")));
            this.PPD1.Name = "PPD1";
            this.PPD1.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.PnlOrder);
            this.Controls.Add(this.FLPFood);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Restaurant Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.PnlOrder.ResumeLayout(false);
            this.PnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.FlowLayoutPanel FLPFood;
        private System.Windows.Forms.Panel PnlOrder;
        private System.Windows.Forms.DataGridView DGVOrders;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBxTenChng;
        private System.Windows.Forms.TextBox TxtBxTenCash;
        private System.Windows.Forms.TextBox TxtBxTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbTP;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7Cat;
        private System.Windows.Forms.Button BtnClear;
    }
}