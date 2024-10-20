namespace CashierApplication
{
    public partial class Form1 : Form
    {
        string name;
        double price;
        double discount;
        int quantity;
        double change;
        double total_price;
        double payment_amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;

            if (double.TryParse(textBox2.Text, out price) && double.TryParse(textBox3.Text, out discount) && int.TryParse(textBox4.Text, out quantity))
            {
                price = double.Parse(textBox2.Text);
                discount = double.Parse(textBox3.Text);
                quantity = int.Parse(textBox4.Text);

                Discount item = new Discount(name, price, discount, quantity);

                total_price = item.getTotalPrice();
                label6.Text = total_price.ToString();
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
    }
}
