using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    class BaristaService
    {
        public void makeCoffee(Order o)
        {
            MessageBox.Show("Making coffee - " + o.Coffee);
        }
    }
}
