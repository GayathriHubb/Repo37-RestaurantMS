using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMS
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";
        private void FormCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) 
            { 
                try
                {
                    DisplayCategoriesData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxCategory.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pls Fill in All Fields", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkcatn = "Select Count(Id) From Categories Where Category = @cat";

                        using (SqlCommand chkcatcmd = new SqlCommand(chkcatn, sqlcon))
                        {
                            chkcatcmd.Parameters.AddWithValue("@cat", TxtBxCategory.Text.Trim());

                            int rowcount = 0;
                            object result = chkcatcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }

                            if (rowcount > 0)
                            {
                                MessageBox.Show($"Category: {TxtBxCategory.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                string insdata = "Insert Into Categories (Category, Status, DateInsert) Values (@cat, @st, @dtins)";

                                using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@cat",TxtBxCategory.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    inscmd.ExecuteNonQuery();
                                    DisplayCategoriesData();
                                    MessageBox.Show("Category Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(TxtBxCategory.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pls Fill in All Fields", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Id: {getid} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update Categories Set Category = @cat, Status = @st, DateUpdate = @dtupd Where id = @id";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@cat", TxtBxCategory.Text.Trim());
                                updcmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);

                                updcmd.ExecuteNonQuery();
                                DisplayCategoriesData();
                                MessageBox.Show("Category Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(TxtBxCategory.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Item First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Id: {getid} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)

                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string deldata = "Delete From Categories Where Id = @id";

                        using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                        {
                            delcmd.Parameters.AddWithValue("@id", getid);

                            delcmd.ExecuteNonQuery();

                            DisplayCategoriesData();
                            MessageBox.Show("Category Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        int getid;
        private void DGVCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVCategories.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;

                    TxtBxCategory.Text = row.Cells[1].Value?.ToString();
                    CmbBxStatus.Text = row.Cells[2].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void ClearFields()
        {
            TxtBxCategory.Clear();
            CmbBxStatus.SelectedIndex = -1;
        }

        private void DisplayCategoriesData()
        {
            CategoriesData cd = new CategoriesData();
            DGVCategories.DataSource = cd.CategoriesList();

        }
            
        
    }
}
