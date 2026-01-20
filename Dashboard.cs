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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    TotalUsersCount();
                    TotalProdsCount();
                    TodaysRevenue();
                    TotalRevenue(); 
                    DisplayTodSales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void TotalUsersCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(Id) as TotalUsers From Users Where Status = @status";

                    using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (sdr["TotalUsers"] != DBNull.Value)
                            {
                                int tu = sdr.GetInt32(0);
                                LbTotUsers.Text = tu.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "UsersCount - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void TotalProdsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(ProductId) as TotalProds From Products Where Status != 'Deleted'";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (sdr["TotalProds"] != DBNull.Value)
                            {
                                int tp = sdr.GetInt32(0);
                                LbTotProds.Text = tp.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ProdsCount - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void TodaysRevenue()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select SUM(TotalPrice) as TodRev From Orders Where DateOrder = @orddt";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@orddt", DateTime.Today);
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (sdr["TodRev"] != DBNull.Value)
                            {
                                float tr = Convert.ToSingle(sdr["TodRev"]);
                                LbTodRev.Text = tr.ToString("C2");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "TodRev - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void TotalRevenue()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select SUM(TotalPrice) as TotRev From Orders";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (sdr["TotRev"] != DBNull.Value)
                            {
                                float tr = Convert.ToSingle(sdr["TotRev"]);
                                LbTotRev.Text = tr.ToString("C2");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "TotRev - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        public void DisplayTodSales()
        {
            CustomersData cd = new CustomersData();
            DGVDashboard.DataSource = cd.TodaySalesList();

            if (MaximizeBox == true)
            {
                DGVDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                DGVDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }

        }
    }
}
