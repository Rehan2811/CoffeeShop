using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    class DonuteerService
    {
        public void packDonuts(Order o)
        {
            MessageBox.Show("Packing donuts - " + o.Donuts);
        }
    }
}
