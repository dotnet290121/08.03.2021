using System;

namespace EventsFriday
{
    public class MealReadyEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public bool Dessert { get; set; }
        public float Price { get; set; }
    }
}
