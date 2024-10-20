using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel.Design;

namespace CashierApp
{
    public partial class Calculator : Form
    {
        string name;
        double price;
        double discount;
        int quantity;
        double change;
        double total_price;
        double payment_amount;
        public Calculator()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;

            if (double.TryParse(textBox2.Text, out price) && double.TryParse(textBox4.Text, out discount) && int.TryParse(textBox3.Text, out quantity))
            {
                price = double.Parse(textBox2.Text);
                discount = double.Parse(textBox4.Text);
                quantity = int.Parse(textBox3.Text);

                Discount item = new Discount(name, price, discount, quantity);

                total_price = item.getTotalPrice();
                label5.Text = total_price.ToString();
            }

            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox5.Text, out payment_amount)) ;
            payment_amount = double.Parse(textBox5.Text);

            Discount dis = new Discount(name, price, discount, quantity);

            dis.setPayment(payment_amount);

            change = dis.getChange();

            if (payment_amount >= total_price)
            {
                label9.Text = change.ToString();

            }
            else
            {
                MessageBox.Show("Insuficient Amount");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Text = "";
            label9.Text = "";
        }

    }
}
