using System;
namespace CashierApp
{
    public partial class Form1 : Form
    {
        string user_name;
        string user_password;
        string full_name;
        string department;
        string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_name = textBox1.Text;
            user_password = textBox2.Text;

            Cashier cs = new Cashier(full_name, department, user_name, user_password);

            if (cs.validateLogin(user_name, user_password))
            {
                name = cs.getFullname();
                department = cs.getDepartment();

                MessageBox.Show("Welcome " + name + " of " + department);
                Calculator calculator = new Calculator();
                calculator.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }
    }
}
