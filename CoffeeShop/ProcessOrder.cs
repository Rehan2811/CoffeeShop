using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop
{
    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order o);

        public event ProcessOrderDelegate OrderSubmitted;
        public void ProcessTheOrder(Order o)
        {
            PaymentService ps = new PaymentService();
            BaristaService bs = new BaristaService();
            DonuteerService ds = new DonuteerService();
            DBService dbs = new DBService();

            this.OrderSubmitted += ps.collectPayment;
            this.OrderSubmitted += bs.makeCoffee;
            this.OrderSubmitted += ds.packDonuts;
            this.OrderSubmitted += dbs.WriteToDB;
            
            /*//Let cashier know to collect cash
            ps.collectPayment(o);
            //Let barista know to make coffee
            bs.makeCoffee(o);
            //Let donuteer know to pack donuts
            ds.packDonuts(o);*/

            OnOrderSubmittted(o);
        }

        protected virtual void OnOrderSubmittted(Order o)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(o);
            }
        }
    }
}
