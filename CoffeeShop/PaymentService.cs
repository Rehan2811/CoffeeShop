using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    class PaymentService
    {
        public void collectPayment(Order o)
        {
            MessageBox.Show("Collecting payment from " + o.Name);
        }
    }
}
