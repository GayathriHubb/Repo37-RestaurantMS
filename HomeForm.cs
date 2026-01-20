using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure To Quit ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            e.Cancel = true;
        }
       
        private void PicBxLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure To Signout ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                Hide();
            }
        }

        private void PicBxLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(PicBxLogout, "Signout");
        }

        private void HomeBtns_CLick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "BtnDashboard":
                    FormDashboard dashboard = new FormDashboard();
                    dashboard.Show();
                    
                    break;
                case "BtnFood":
                    FormMenu orders = new FormMenu();
                    orders.Show();
                    
                    break;
                case "BtnCategories":
                    FormCategories categories = new FormCategories();
                    categories.Show();
                    
                    break;
                case "BtnInventory":
                    FormInventory inventory = new FormInventory();
                    inventory.Show();
                    
                    break;
                case "BtnCustomers":
                    FormCustomers customers = new FormCustomers();
                    customers.Show();
                    
                    break;
                default:
                    break;

            }

            Hide();
        }
    }
}
