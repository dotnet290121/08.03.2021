using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsFriday
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Waiter waiter = new Waiter(null);
            Cashier cashier = new Cashier();

            kitchen.MealEventHandler += waiter.TakeOutMealFromKitchen;

            kitchen.MealEventHandler += cashier.AddMealToDaySum;

            // problems:
            // 1 
            //kitchen.MealEventHandler = null;
            // 2
            //kitchen.MealEventHandler("I am the king!", null);

            //kitchen.delegate_event_handler -= waiter.TakeOutMealFromKitchen;

            kitchen.PrepareMeal("Pizza with olives", false, 84.3f);


        }

    }
}
