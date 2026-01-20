using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMS
{
    internal class CategoriesData
    {
        public CategoriesData() { }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        public int Id { get; set; }
        public string Category {  get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }

        public List<CategoriesData> CategoriesList()
        {
            List<CategoriesData> catlist = new List<CategoriesData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Categories";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    { 
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {    
                            CategoriesData cd = new CategoriesData();
                            
                            cd.Id = sdr.GetInt32(0);
                            cd.Category = sdr.GetString(1);
                            cd.Status = sdr.GetString(2);
                            cd.DateInsert = (Convert.ToDateTime(sdr["DateInsert"]).ToString("dd-MM-yyyy"));

                            catlist.Add(cd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CategoriesData");
                }
            }

            return catlist;
        }
    }
}
