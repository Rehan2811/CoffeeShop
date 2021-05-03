using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    class DBService
    {
        public void WriteToDB(Order o)
        {
            MessageBox.Show("Writing to DB " + o.Coffee);
        }
    }
}
