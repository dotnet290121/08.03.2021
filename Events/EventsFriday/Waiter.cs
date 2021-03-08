using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFriday
{
    class Waiter
    {
        //    public Action<object, MealReadyEventArgs> delegate_event_handler;

        public void TakeOutMealFromKitchen(object sender, MealReadyEventArgs e)
        {
            if (sender is Kitchen)
            {

            }
            Console.WriteLine("Wait was informed that the meal is ready...");
            Console.WriteLine($"The waiter will take the {(e.Dessert ? "dessert" : "course")} {e.DishName} to the table");
        }

        public Waiter(IMealPublisher meal_publisher)
        {
            if (meal_publisher != null)
            {
                meal_publisher.MealEventHandler += TakeOutMealFromKitchen;
            }
        }

    }
}
