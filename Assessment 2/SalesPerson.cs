using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2
{
    class SalesPerson
    {
        private string id;
        private Sale[] salesHistory;
        private int count = 0;

        public SalesPerson(string id)
        {
            this.id = id;
            salesHistory = new Sale[100];
        }

        public int getCount()
        {
            return count;
        }

        public string getId()
        {
            return id;
        }

        public void setSalesHistory(Sale s)
        {
            salesHistory[count] = s;
            count = count + 1;
        }

        public double calcTotalSales()
        {

           int i = 0;
           double totalSale = 0;

           for(i=0; i < count; i++)
           {
             if (salesHistory[i].getValue() != 0)   // check for null
             {
                double value = salesHistory[i].getValue();
                int quantity = salesHistory[i].getQuantity();
                totalSale = totalSale+(value * quantity);
             }
           }
        
            return totalSale;
        }

        public Sale getSalesHistory(int i)
        {
            return salesHistory[i];
        }
    }
}
