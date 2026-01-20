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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\RestaurantMS\Restaurant.mdf;Integrated Security = True";

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Hide();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPswrd.Text) || string.IsNullOrEmpty(TxtBxCnfrmPswrd.Text))
            {
                MessageBox.Show("Pls Fill in All Fields", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else if (TxtBxPswrd.Text.Trim().Length < 8)
            {
                MessageBox.Show("Invalid Password.. Must be 8 Characters or up", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else if (TxtBxCnfrmPswrd.Text.Trim().Length != TxtBxCnfrmPswrd.Text.Trim().Length)
            {
                MessageBox.Show("Passwords Does Not Match", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into Users (Username, Password, Status, DateRegister) Values (@un, @pswrd, @st, @dtrg)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            inscmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());
                            inscmd.Parameters.AddWithValue("@st", "Active");
                            inscmd.Parameters.AddWithValue("@dtrg", DateTime.Today);

                            inscmd.ExecuteNonQuery();

                            MessageBox.Show("Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            FormLogin login = new FormLogin();
                            login.Show();
                            Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SignUp - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear(); 
            TxtBxCnfrmPswrd.Clear();    
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfrmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }

       
    }
}
