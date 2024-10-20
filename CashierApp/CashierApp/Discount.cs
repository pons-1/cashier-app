using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class Discount : Items
    {
        private double item_discount;
        private double discount_price;
        private double change;
        private double payment_amount;

        public Discount(string name, double price, double discount, int quantity) : base(name, price, quantity)
        {
            this.item_discount = discount;
            this.discount_price = item_price * (1 - discount * 0.01);
            this.change = 0;

        }

        public double getTotalPrice()
        {
            return this.discount_price * item_quantity;

        }

        public override void setPayment(double amount)
        {
            change = amount - getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }
    }
}
