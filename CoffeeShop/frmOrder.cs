using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCoffee_Click(object sender, EventArgs e)
        {

        }

        private void txbCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDonuts_Click(object sender, EventArgs e)
        {

        }

        private void txbDonuts_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int coffee = Convert.ToInt32(txbCoffee.Text);
            int donuts = Convert.ToInt32(txbDonuts.Text);

            Order o = new Order(name, coffee, donuts);

            ProcessOrder p = new ProcessOrder();
            p.ProcessTheOrder(o);
        }
    }
}
