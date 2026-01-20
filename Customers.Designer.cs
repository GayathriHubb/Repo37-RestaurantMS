namespace RestaurantMS
{
    partial class FormCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            this.LbHeading = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.BtnReceipt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbHeading.Location = new System.Drawing.Point(440, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(119, 25);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "CUSTOMERS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl1.Controls.Add(this.BtnReceipt);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Controls.Add(this.DGVCustomers);
            this.Pnl1.Location = new System.Drawing.Point(9, 40);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(960, 590);
            this.Pnl1.TabIndex = 3;
            // 
            // BtnReceipt
            // 
            this.BtnReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.BtnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnReceipt.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnReceipt.Location = new System.Drawing.Point(410, 540);
            this.BtnReceipt.Name = "BtnReceipt";
            this.BtnReceipt.Size = new System.Drawing.Size(140, 35);
            this.BtnReceipt.TabIndex = 1;
            this.BtnReceipt.Text = "Receipt";
            this.BtnReceipt.UseVisualStyleBackColor = false;
            this.BtnReceipt.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCustomers.BackgroundColor = System.Drawing.Color.DimGray;
            this.DGVCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCustomers.ColumnHeadersHeight = 34;
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCustomers.EnableHeadersVisualStyles = false;
            this.DGVCustomers.Location = new System.Drawing.Point(0, 40);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCustomers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCustomers.RowTemplate.Height = 28;
            this.DGVCustomers.Size = new System.Drawing.Size(960, 490);
            this.DGVCustomers.TabIndex = 4;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellClick);
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
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCustomers";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Restaurant Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomers_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReceipt;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
    }
}