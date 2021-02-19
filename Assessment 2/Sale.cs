using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class Sale
    {
        private string itemId;
        private double value;
        private int quantity;

        public Sale(string itemId, double value, int quantity)
        {
            string Itemid = itemId;
            this.value = value;
            this.quantity = quantity;
        }

        public double getValue()
        {
            return value;
        }

        public int getQuantity()
        {
            return quantity;
        }
    }
}
