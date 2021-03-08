using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFriday
{
    class Cashier
    {
        static double total_balance = 0;
        public void AddMealToDaySum(object sender, MealReadyEventArgs e)
        {
            Console.WriteLine($"Cashier was notified upon new meal for customer in the price of {e.Price}");
            total_balance += e.Price;
        }
    }
}
