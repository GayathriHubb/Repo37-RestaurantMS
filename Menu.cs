using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestaurantMS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    LoadCardProducts();
                    CalcTotalPrice();
                    DGVOrders.ScrollBars = ScrollBars.None;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }


        bool countflag = false;
        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!amntchk)
            {
                MessageBox.Show("Please Enter Tendered Amount and Press Enter Key", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you Sure to Place Order ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        IdGenerator();

                        List<string> PdIds = new List<string>();
                        List<string> PdQts = new List<string>();
                        List<string> PdPrices = new List<string>();

                        foreach (DataGridViewRow row in DGVOrders.Rows)
                        {
                            if (row.Cells["Col2Id"].Value != null)
                            {
                                PdIds.Add(row.Cells["Col2Id"].Value.ToString());
                                PdQts.Add(row.Cells["Col5ProdQty"].Value.ToString());
                                PdPrices.Add(row.Cells["Col6ProdPrice"].Value.ToString());
                            }
                        }

                        string pdidsstr = string.Join(", ", PdIds);
                        string pdqtsstr = string.Join(", ", PdQts);
                        string pdpricesstr = string.Join(", ", PdPrices);

                        string insdata = "Insert Into Orders (CustId, ProdIds, ProdQtys, ProdPrices, TotalPrice, DateOrder) Values (@cid, @pids, @pqtys, @pprs, @tp, @orddt)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@cid", $"CST{count}");
                            inscmd.Parameters.AddWithValue("@pids", pdidsstr);
                            inscmd.Parameters.AddWithValue("@pqtys", pdqtsstr);
                            inscmd.Parameters.AddWithValue("@pprs", pdpricesstr);
                            inscmd.Parameters.AddWithValue("@tp", Convert.ToSingle(TxtBxTP.Text.Trim()));
                            inscmd.Parameters.AddWithValue("@orddt", DateTime.Today);

                            int ra = inscmd.ExecuteNonQuery();

                            // Update Products Stock
                            if (ra > 0)
                            {
                                for (int i = 0; i < PdIds.Count; i++)
                                {
                                    string getprodid = PdIds[i];
                                    int getqty = Convert.ToInt32(PdQts[i]);
                                    string updatestock = "Update Products Set Stock = Stock - @qty Where Id = @id";
                                    using (SqlCommand upcmd = new SqlCommand(updatestock, sqlcon))
                                    {
                                        upcmd.Parameters.AddWithValue("@qty", getqty);
                                        upcmd.Parameters.AddWithValue("@id", getprodid);
                                        upcmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Order Placed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        string insdata2 = "Insert Into Customers (CustId, TotalPrice, Amount, Change, OrderDate) Values (@cstid, @tp, @amnt, @chng, @orddt)";

                        using (SqlCommand inscmd2 = new SqlCommand(insdata2, sqlcon))
                        {
                            inscmd2.Parameters.AddWithValue("@cstid", $"CST{count}");
                            inscmd2.Parameters.AddWithValue("@tp", Convert.ToSingle(TxtBxTP.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@amnt", Convert.ToSingle(TxtBxTenCash.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@chng", Convert.ToSingle(TxtBxTenChng.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@orddt", DateTime.Today);

                            inscmd2.ExecuteNonQuery();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Orders - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

        }

        int count = 1;
        private void IdGenerator()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string countdata = "Select Count(Id) From Orders";

                    count = 1;
                    using (SqlCommand countcmd = new SqlCommand(countdata, sqlcon))
                    {
                        object result = countcmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result) + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "IdGenerator - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        bool amntchk = false;
        private void TxtBxTenCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float totalprice = float.Parse(TxtBxTP.Text);
                    float amount = float.Parse(TxtBxTenCash.Text);

                    if (amount < totalprice)
                    {
                        MessageBox.Show("Insufficient Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtBxTenChng.Text = "0.00";
                        amntchk = false;
                    }
                    else
                    {
                        float change = amount - totalprice;
                        TxtBxTenChng.Text = $"{change:F2}";
                        amntchk = true;
                    }
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Amount - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        int rowindex;
        private void PD1_PrintPage(object sender, PrintPageEventArgs e)
        {
            IdGenerator();
            CalcTotalPrice();
            

            int y = 50;
            int left = 50;
            int colwidth = 150;

            Font headerfont = new Font("Cambria", 18, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font smallfont = new Font("Segoe UI", 10, FontStyle.Bold);

            int centrex1 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Cuisine Veg Restaurant", headerfont).Width) / 2;
            int centrex2 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Thank You for Shopping!", font).Width) / 2;
            int centrex3 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Visit Again!", font).Width) / 2;

            // ✅ Store Header
            e.Graphics.DrawString("Cuisine Veg Restaurant", headerfont, Brushes.Firebrick, centrex1, y);
            y += 80;

            string date = $"Date: {DateTime.Now:dd/MM/yyyy hh:mm tt}";
            int datex = (int)((left + 750) - e.Graphics.MeasureString(date, font).Width);

            // ✅ Date + Bill No
            e.Graphics.DrawString($"Bill No: {count - 1}", font, Brushes.Black, left, y);
            e.Graphics.DrawString(date, font, Brushes.Black, datex, y);
            y += 30;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 20;

            // ✅ Table Headers
            string[] headers = { "Product Id", "ProductName", "Category", "Quantity", "Price" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], font, Brushes.Navy, left + (i * colwidth), y);
            }
            y += 25;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 10;

            // ✅ Table Rows
            while (rowindex < DGVOrders.Rows.Count)
            {
                DataGridViewRow row = DGVOrders.Rows[rowindex];

                e.Graphics.DrawString(row.Cells[2].Value.ToString(), smallfont, Brushes.Black, left + 0, y);

                string pname = row.Cells[3].Value.ToString();

                // Limit text width so it wraps
                int textwidth = 150;
                SizeF textsize = e.Graphics.MeasureString(pname, smallfont, textwidth);

                // Draw wrapped product name
                e.Graphics.DrawString(pname, smallfont, Brushes.Black, new RectangleF(left + 150, y, textwidth, textsize.Height));
                e.Graphics.DrawString(row.Cells[6].Value.ToString(), smallfont, Brushes.Black, left + 300, y);
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), smallfont, Brushes.Black, left + 450, y);
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), smallfont, Brushes.Black, left + 600, y);

                y += (int)textsize.Height > 25 ? (int)textsize.Height : 25;
                rowindex++;

                if (y > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            y += 20;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 30;

            // ✅ Summary Price Section
            DrawRightAligned(e.Graphics, "TotalPrice(₹):", $"{TxtBxTP.Text: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedCash(₹):", $"{TxtBxTenCash.Text: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedChange(₹):", $"{TxtBxTenChng.Text: 0.00}", font, left, ref y);

            y += 30;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 30;

            // ✅ Footer
            e.Graphics.DrawString("Thank You for Shopping!", font, Brushes.Black, centrex2, y);
            y += 25;
            e.Graphics.DrawString("Visit Again!", smallfont, Brushes.Black, centrex3, y);

            e.HasMorePages = false;

        }
        private void DrawRightAligned(Graphics g, string label, string value, Font font, int left, ref int y)
        {
            g.DrawString(label, font, Brushes.Navy, left + 300, y);
            g.DrawString(value, font, Brushes.Black, left + 520, y);
            y += 30;
        }

        
        DataGridViewRow row; int id;
        private void DGVOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                row = DGVOrders.Rows[e.RowIndex];

                id = (int)row.Cells["Col2Id"].Value;
            }
        }


        public void CardItems(int id, string prodid, string category, string prodname, string stock, string price, string imgloc, int qty)
        {
            UCFoodCard fdcrd = new UCFoodCard
            {
                Id = id,
                ProdId = prodid,
                Category = category,
                ProdName = prodname,
                ProdStock = stock,
                ProdPrice = price,
                ProdImage = imgloc,
                ProdQty = qty
            };

            FLPFood.Controls.Add(fdcrd);
            fdcrd.SelectCard += FdCrdAdd_SelectCard;
        }

        int getqty;
        float getprice; double tppp;
        private void FdCrdAdd_SelectCard(object sender, EventArgs e)
        {
            UCFoodCard selectedcard = sender as UCFoodCard;
            bool flag = false;
            
            try
            {
                IdGenerator();

                foreach (DataGridViewRow row in DGVOrders.Rows)
                {
                    if (row.Cells["Col2Id"].Value != null && (int)row.Cells["Col2Id"].Value == selectedcard.Id)
                    {
                        if (selectedcard.ProdQty > 0)
                        {
                            getprice = Convert.ToSingle(selectedcard.ProdPrice);
                            getqty = selectedcard.ProdQty;
                            tppp = getprice * getqty;

                            row.Cells["Col1CustId"].Value = $"CST{count}";
                            row.Cells["Col6ProdPrice"].Value = tppp;
                            row.Cells["Col5ProdQty"].Value = selectedcard.ProdQty;
                        }

                        flag = true;
                        break;
                    }
                }

                if (selectedcard.ProdQty <= 0)
                {
                    MessageBox.Show("Qty Cannot be 0 or Less..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!flag)
                {

                    DGVOrders.ScrollBars = ScrollBars.Both;
                    getprice = Convert.ToSingle(selectedcard.ProdPrice);
                    getqty = selectedcard.ProdQty;
                    tppp = getprice * getqty;
                    
                    DGVOrders.Rows.Add($"CST{count}", selectedcard.Id, selectedcard.ProdId, selectedcard.ProdName, selectedcard.ProdQty, tppp, selectedcard.Category);
                }
                
                CalcTotalPrice();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SelectCard - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        
        public void LoadCardProducts()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Products";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        FLPFood.Controls.Clear();

                        while (sdr.Read())
                        {
                            int id = (sdr["Id"] != DBNull.Value) ? (int)sdr["Id"] : 0;
                            string prodid = (sdr["ProductId"] != DBNull.Value) ? (string)sdr["ProductId"] : "N/A";
                            string category = (sdr["Category"] != DBNull.Value) ? (string)sdr["Category"] : "N/A";
                            string prodname = (sdr["ProductName"] != DBNull.Value) ? (string)sdr["ProductName"] : "N/A";
                            string stock = (sdr["Stock"] != DBNull.Value) ? sdr["Stock"].ToString() : "0";
                            string price = (sdr["Price"] != DBNull.Value) ? $"{sdr["Price"]:0.##}" : "0.00";
                            string imgpath = (sdr["ImagePath"] != DBNull.Value) ? (string)sdr["ImagePath"] : string.Empty;

                            
                            CardItems(id, prodid, category, prodname, stock, price, imgpath, default);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (DGVOrders.RowCount == 0 || id == 0)
            {
                MessageBox.Show("Pls Select Item First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Remove Id: {id} ?", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (row != null)
                        {
                            DGVOrders.Rows.Remove(row);
                            CalcTotalPrice();

                            MessageBox.Show("Item Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "DGV|Error");
                        Debug.WriteLine(ex, "DGVOrders");
                    }

                }
            }
        }

        private void CalcTotalPrice()
        {
            double totalprice = 0;

            foreach (DataGridViewRow row in DGVOrders.Rows)
            {
                if (DGVOrders.Rows.Count == 0)
                {
                    TxtBxTP.Text = string.Empty;
                }
                if (row.Cells["Col6ProdPrice"].Value != null)
                {
                    double colvalues = Convert.ToDouble(row.Cells["Col6ProdPrice"].Value);
                    totalprice += colvalues;
                }
            }
            TxtBxTP.Text = $"{totalprice:F2}";
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                PPD1.ShowDialog();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "BtnReceipt");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxTP.Clear();
            TxtBxTenCash.Clear();
            TxtBxTenChng.Clear();
        }
    }

}











