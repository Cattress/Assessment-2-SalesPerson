using System;

namespace Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cheese");
            SalesPerson[] salesPeople = new SalesPerson[6];
            salesPeople[0] = new SalesPerson("100");
            salesPeople[1] = new SalesPerson("101");
            salesPeople[2] = new SalesPerson("102");

            salesPeople[0].setSalesHistory(new Sale("A100", 300.00, 10));
            salesPeople[0].setSalesHistory(new Sale("A200", 1000.00, 2));
            salesPeople[1].setSalesHistory(new Sale("A300", 2550.40, 10));

            Console.WriteLine(salesPeople[2].getId());
            Console.WriteLine(salesPeople[0].getCount());
            Console.WriteLine(salesPeople[1].getSalesHistory(0).getValue());
            Console.WriteLine(salesPeople[0].calcTotalSales());

        }
    }
}
