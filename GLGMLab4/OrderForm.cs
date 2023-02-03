using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GLGMLab4
{
    public partial class OrderForm : Form
    {
        List<Order> orders = new List<Order>();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Order firstOrder = new Order();
            firstOrder.Name = "Gregory Lejeune";
            firstOrder.OrderID = 500;
            Order secondOrder = new Order("Graeme Mackay",true,-10);
            DisplayList();
        }
        private void DisplayList()
        {
            lstOrders.Items.Clear();
            cboOrderSelect.Items.Clear();
            decimal grandTotal = 0;

            foreach (Order order in orders)
            {
                lstOrders.Items.Add(order.DisplayData());
                cboOrderSelect.Items.Add(order.Name);
                grandTotal += order.Amount;
            }

            lblGrandTotalDisplay.Text = grandTotal.ToString("C");
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (txtNameEntry.TextLength > 5)
            {
                Order newOrder = new Order();
                newOrder.Name = txtNameEntry.Text;
                DisplayList();
            }
            else
            {
                MessageBox.Show("Please enter more then 5 characters for the Name" ,"Error Message");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEntry.Text = "";
            lstOrders.Items.Clear();
            cboOrderSelect.Items.Clear();
            txtNameEntry.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closing = MessageBox.Show("Are you sure you want to close the form", "Confirm Close", MessageBoxButtons.YesNo);

            if (closing == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnReadOrders_Click(object sender, EventArgs e)
        {
            if (lstOrders.Items.Count > 0) 
            {
                MessageBox.Show("Orders already in list", "Clear to add orders");
            }
            

        }
    }
}
