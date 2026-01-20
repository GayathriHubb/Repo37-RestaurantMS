namespace RestaurantMS
{
    partial class FormLoad
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
            this.components = new System.ComponentModel.Container();
            this.LbHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicBxGif = new System.Windows.Forms.PictureBox();
            this.PicBxRestaurant = new System.Windows.Forms.PictureBox();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.FloralWhite;
            this.LbHeading.Location = new System.Drawing.Point(163, 30);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(452, 44);
            this.LbHeading.TabIndex = 1;
            this.LbHeading.Text = "CUISINE VEG RESTAURANT";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(124, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl1.Controls.Add(this.Pnl2);
            this.Pnl1.Location = new System.Drawing.Point(0, 450);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(778, 30);
            this.Pnl1.TabIndex = 3;
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl2.Location = new System.Drawing.Point(0, 0);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(80, 30);
            this.Pnl2.TabIndex = 0;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 20;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PicBxGif
            // 
            this.PicBxGif.Image = global::RestaurantMS.Properties.Resources.LoadingCircleDesign;
            this.PicBxGif.Location = new System.Drawing.Point(598, 345);
            this.PicBxGif.Name = "PicBxGif";
            this.PicBxGif.Size = new System.Drawing.Size(80, 80);
            this.PicBxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGif.TabIndex = 4;
            this.PicBxGif.TabStop = false;
            // 
            // PicBxRestaurant
            // 
            this.PicBxRestaurant.Image = global::RestaurantMS.Properties.Resources.RestaurantWin11;
            this.PicBxRestaurant.Location = new System.Drawing.Point(312, 100);
            this.PicBxRestaurant.Name = "PicBxRestaurant";
            this.PicBxRestaurant.Size = new System.Drawing.Size(150, 150);
            this.PicBxRestaurant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxRestaurant.TabIndex = 0;
            this.PicBxRestaurant.TabStop = false;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.PicBxGif);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.PicBxRestaurant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLoad";
            this.Text = "Restaurant Management System";
            this.Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxRestaurant;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.PictureBox PicBxGif;
        private System.Windows.Forms.Timer Timer1;
    }
}

