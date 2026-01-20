using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMS
{
    internal class ProductsData
    {
        public ProductsData() { }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        public int Id { get; set; }
        public string Category { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Stock {  get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }

        public List<ProductsData> ProductsList()
        {
            List<ProductsData> prodslist = new List<ProductsData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Products Where DateDelete is NULL AND Status != 'Deleted'";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon)) 
                    { 
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            ProductsData pd = new ProductsData();

                            pd.Id = sdr.GetInt32(0);
                            pd.Category = sdr.GetString(1);
                            pd.ProductId = sdr.GetString(2);
                            pd.ProductName = sdr.GetString(3);
                            pd.Stock = sdr.GetInt32(4);
                            pd.Price = Convert.ToSingle(sdr["Price"]);
                            pd.ImagePath = sdr["ImagePath"].ToString();
                            pd.Status = sdr["Status"].ToString();
                            pd.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy hh:mm tt");
                            pd.DateUpdate = (sdr["DateUpdate"] == DBNull.Value) ? null : (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");

                            prodslist.Add(pd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "ProductsData");
                }
            }

            return prodslist;
        }

    }
}
