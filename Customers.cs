using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RestaurantMS
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayCustmsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        DataGridViewRow row;
        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                row = DGVCustomers.Rows[e.RowIndex];
            }
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                PPD1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Receipt - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void PD1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;

                int centrex1 = (int)(e.PageBounds.Width - g.MeasureString("Cuisine Veg Restaurant", new Font("Cambria", 18, FontStyle.Bold)).Width) / 2;
                int centrex2 = (int)(e.PageBounds.Width - g.MeasureString("------------  HAVE A NICE DAY  ------------", new Font("Cambria", 16, FontStyle.Bold)).Width) / 2;
                int heading1y = 100;
                int remdatay = heading1y + 100;
                int left = 20;

                Font f = new Font("Lucida Fax", 13, FontStyle.Bold);

                g.DrawString("Cuisine Veg Restaurant", new Font("Cambria", 16, FontStyle.Bold), Brushes.Firebrick, new Point(centrex1, heading1y));

                DrawLeftAligned(e.Graphics, "Customer Id: ", row.Cells[1].Value?.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TotalPrice: ", row.Cells[2].Value?.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TenderedCash: ", row.Cells[3].Value?.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TenderedChange: ", row.Cells[4].Value?.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "OrderDate: ", row.Cells[5].Value?.ToString(), f, left, ref remdatay);

                g.DrawString("------------  HAVE A NICE DAY  ------------", f, Brushes.Firebrick, new Point(centrex2, remdatay + 250));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVCustomers");
            }

        }

        private void DrawLeftAligned(Graphics g, string label, string value, Font font, int left, ref int y)
        {
            g.DrawString(label, font, Brushes.Navy, left + 40, y);
            g.DrawString(value, font, Brushes.Black, left + 260, y);
            y += 40;
        }

        private void DisplayCustmsData()
        {
            CustomersData cd = new CustomersData();
            DGVCustomers.DataSource = cd.CustomersList();
        }

       
    }
}
