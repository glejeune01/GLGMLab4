using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLGMLab4
{
    public class Order
    {
        private int orderID;
        private string name;
        private bool delivery;
        private decimal amount;
        private static int nextID = 500;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    amount = 0;
                }
            }
        }

        public Order()
        {
            SetID();
            Delivery = true;
            amount = 159.99M;
        }

        public Order(string name, bool delivery, decimal amount)
        {
            SetID();
            this.name = name;
            this.delivery = delivery;
            this.amount = amount;
        }

        private void SetID()
        {
            OrderID = nextID;
            nextID += 10;
        }

        public string DisplayData() => orderID.ToString() + "\t" + name + amount.ToString("C");
    }
}
