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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPswrd.Text))
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

                        string chkun = "Select Count(Id) From Users Where Username = @un AND Password = @pswrd";

                        using (SqlCommand chkuncmd = new SqlCommand(chkun, sqlcon))
                        {
                            chkuncmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            chkuncmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());

                            int rowcount = 0;
                            object result = chkuncmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rowcount = Convert.ToInt32(result);
                            }

                            if (rowcount > 0)
                            {
                                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                HomeForm home = new HomeForm();
                                home.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SignIn - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
