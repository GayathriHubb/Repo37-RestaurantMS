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
using System.IO;
using System.Data.SqlClient;

namespace RestaurantMS
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";
        string targetpath;
        private void FormInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayProdsData();
                    DisplayCategoriesInCB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Pls Fill in All Fields and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidStock(TxtBxStock.Text, out int stock))
            {
                MessageBox.Show("Invalid Stock Input.. Pls Enter a Valid Integer", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidPrice(TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price Input.. Pls Enter a Valid Amount", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string targetpath = string.Empty;
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("ProdsDirectory", $"{TxtBxProdId.Text.Trim().ToUpper()}.jpg");
                    targetpath = Path.Combine(basedirectory, relativepath);

                    string directorypath = Path.GetDirectoryName(targetpath);

                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }

                    if (!string.IsNullOrEmpty(PicBxProd.ImageLocation))
                    {
                        File.Copy(PicBxProd.ImageLocation, targetpath, true);
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "Insert|PicBx");
                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkpid = "Select Count(Id) From Products Where ProductId = @pid";

                        using (SqlCommand chkpidcmd =  new SqlCommand(chkpid, sqlcon))
                        {
                            chkpidcmd.Parameters.AddWithValue("@pid", TxtBxProdId.Text.Trim());

                            int rowcount = 0;
                            object result = chkpidcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = (int)result;
                            }

                            if (rowcount > 0)
                            {
                                MessageBox.Show($"ProductId: {TxtBxProdId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            else
                            {
                                string insdata = "Insert Into Products (ProductId, ProductName, Category, Stock, Price, Status, ImagePath, DateInsert) Values (@pid, @pname, @cat, @stock, @price, @status, @imgpath, @dtins)";

                                using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@pid", TxtBxProdId.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@pname", TxtBxProdName.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@cat", CmbBxCategory.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@stock", stock);
                                    inscmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                    inscmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Now);

                                    inscmd.ExecuteNonQuery();
                                    DisplayProdsData();
                                    MessageBox.Show("Product Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Insert - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Pls Fill in All Fields", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidStock(TxtBxStock.Text, out int stock))
            {
                MessageBox.Show("Invalid Stock Input.. Pls Enter a Valid Integer", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidPrice(TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price Input.. Pls Enter a Valid Amount", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Id: {getid} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativepath = Path.Combine("ProdsDirectory", $"{TxtBxProdId.Text.Trim().ToUpper()}.jpg");
                        targetpath = Path.Combine(basedirectory, relativepath);

                        if (!string.IsNullOrEmpty(PicBxProd.ImageLocation))
                        {
                            File.Copy(PicBxProd.ImageLocation, targetpath, true);
                        }

                        MessageBox.Show("Image Updated Successfully", "Image - Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "Update|PicBx");
                    }
                    
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update Products Set ProductName = @pname, Category = @cat, Stock = @stock, Price = @price, Status = @status, ImagePath = @imgpath, DateUpdate = @dtupd Where ProductId = @pid AND Id = @id";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@pname", TxtBxProdName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@cat", CmbBxCategory.Text.Trim());
                                updcmd.Parameters.AddWithValue("@stock", stock);
                                updcmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                updcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                updcmd.Parameters.AddWithValue("@pid", TxtBxProdId.Text.Trim());
                                updcmd.Parameters.AddWithValue("@id", getid);

                                updcmd.ExecuteNonQuery();
                                DisplayProdsData();
                                MessageBox.Show("Product Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Update - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxProdId.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Item First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Id: {getid} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Update Products Set DateDelete = @dtdel AND Status = @status Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("id", getid);
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);
                                delcmd.Parameters.AddWithValue("@status", "Deleted");

                                delcmd.ExecuteNonQuery();
                                DisplayProdsData();
                                MessageBox.Show("Product Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Delete - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            string imgpath = string.Empty;

            try
            {
                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd.FileName;
                    PicBxProd.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        int getid;
        private void DGVInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVProducts.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    CmbBxCategory.Text = row.Cells[1].Value?.ToString();
                    TxtBxProdId.Text = row.Cells[2].Value?.ToString();
                    TxtBxProdName.Text = row.Cells[3].Value?.ToString();
                    TxtBxStock.Text = row.Cells[4].Value?.ToString();
                    TxtBxPrice.Text = row.Cells[5].Value?.ToString();
                    CmbBxStatus.Text = row.Cells[6].Value?.ToString();

                    string imgpath = row.Cells[7].Value.ToString();

                    if (File.Exists(imgpath))
                    {
                        PicBxProd.ImageLocation = imgpath;
                    }
                    PicBxProd.Image = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        public void DisplayCategoriesInCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Categories";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        CmbBxCategory.Items.Clear();
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                string category = (string)sdr["Category"];
                                CmbBxCategory.Items.Add(category);
                            }
                        }
                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxProdId.Text) || string.IsNullOrEmpty(TxtBxProdName.Text) || string.IsNullOrEmpty(TxtBxStock.Text) || string.IsNullOrEmpty(TxtBxPrice.Text) ||
               CmbBxCategory.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1 || PicBxProd.Image == null)
            {
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            TxtBxProdId.Text = string.Empty;
            TxtBxProdName.Text = string.Empty;
            TxtBxStock.Text = string.Empty;
            TxtBxPrice.Text = string.Empty;
            CmbBxCategory.Text = string.Empty;
            CmbBxStatus.Text = string.Empty;
            PicBxProd.Image = null;

        }

        private static bool ValidStock(string stocktext, out int stock)
        {
            if(int.TryParse(stocktext, out stock))
            {
                if (stock >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidPrice(string pricetext, out float price)
        {
            if (float.TryParse(pricetext, out price))
            {
                if (price >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void DisplayProdsData()
        {
            ProductsData pd = new ProductsData();
            DGVProducts.DataSource = pd.ProductsList();

        }
            

    }
}
