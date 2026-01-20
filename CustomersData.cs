using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMS
{
    internal class CustomersData
    {
        public CustomersData() { }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        public int Id { get; set; }
        public string CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public float TenderedCash { get; set; }
        public float TenderedChange { get; set; }
        public string OrderDate { get; set; }

        public List<CustomersData> CustomersList()
        {
            List<CustomersData> custslist = new List<CustomersData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Customers";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            CustomersData cd = new CustomersData();

                            cd.Id = sdr.GetInt32(0);
                            cd.CustomerId = (string)sdr["CustId"];
                            cd.TotalPrice = Convert.ToSingle(sdr["TotalPrice"]);
                            cd.TenderedCash = Convert.ToSingle(sdr["Amount"]);
                            cd.TenderedChange = Convert.ToSingle(sdr["Change"]);
                            cd.OrderDate = (Convert.ToDateTime(sdr["OrderDate"])).ToString("dd-MM-yyyy");

                            custslist.Add(cd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustomersData");
                }
            }

            return custslist;
        }

        public List<CustomersData> TodaySalesList()
        {
            List<CustomersData> custslist = new List<CustomersData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Customers Where OrderDate = @orddt";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@orddt", DateTime.Today);
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            CustomersData cd = new CustomersData();

                            cd.Id = sdr.GetInt32(0);
                            cd.CustomerId = (string)sdr["CustId"];
                            cd.TotalPrice = Convert.ToSingle(sdr["TotalPrice"]);
                            cd.TenderedCash = Convert.ToSingle(sdr["Amount"]);
                            cd.TenderedChange = Convert.ToSingle(sdr["Change"]);
                            cd.OrderDate = (Convert.ToDateTime(sdr["OrderDate"])).ToString("dd-MM-yyyy");

                            custslist.Add(cd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustomersData");
                }
            }

            return custslist;

        }

    }
}
