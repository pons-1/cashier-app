using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public abstract class Items
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;
        

        public Items(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.total_price = price * quantity;
        }

        public double getTotalPrice() 
        {
            return total_price;
        }

        public abstract void setPayment(double amount);
    }
}
