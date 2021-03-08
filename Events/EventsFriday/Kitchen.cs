using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsFriday
{
    class Kitchen : IMealPublisher
    {
        // void func(object sender, Eventargs e)

        //public Action<object, MealReadyEventArgs> my_delegate_event_handler;

        public event EventHandler<MealReadyEventArgs> MealEventHandler;

        private void PublishMealRedy(string meal, bool isDessert, float price)
        {
            if (MealEventHandler != null)
            {
                MealEventHandler.Invoke(this, new MealReadyEventArgs
                {
                    Dessert = isDessert,
                    DishName = meal,
                    Price = price
                });
            }
        }

        public void PrepareMeal(string meal, bool isDessert, float price)
        {
            Console.WriteLine("Preparing meal...");
            Thread.Sleep(1000);
            PublishMealRedy(meal, isDessert, price);
        }
    }
}
