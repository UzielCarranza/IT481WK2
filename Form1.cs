using System;
using System.Windows.Forms;

namespace it481WK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        // event listener to display the number of customers
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = CustomerController.getCustomerCount().ToString() + " customers";
        }
        // event listener to display the customer names on the listbox object
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = CustomerController.getListOfCustomerNames();
        }
    }
}
