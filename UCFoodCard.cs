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
    public partial class UCFoodCard : UserControl
    {
        public UCFoodCard()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string ProdId { get; set; }
        public string Category {  get; set; }

        public string ProdName
        {
            get { return LbProdName.Text; }
            set { LbProdName.Text = value; }
        }

        public string ProdStock
        {
            get { return LbStock.Text; }
            set { LbStock.Text = value; }
        }

        public string ProdPrice
        {
            get { return LbPrice.Text; }
            set { LbPrice.Text = value; }
        }

        public string ProdImage
        {
            get { return PicBxFood.ImageLocation; }
            set { PicBxFood.ImageLocation = value; }
        }

        public int ProdQty
        {
            get { return (int)NumUDQty.Value; }
            set { NumUDQty.Value = (int)value; }
        }

        public event EventHandler SelectCard = null;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SelectCard?.Invoke(this, EventArgs.Empty);
        }
    }
}
