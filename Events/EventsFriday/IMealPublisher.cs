using System;

namespace EventsFriday
{
    internal interface IMealPublisher
    {
        event EventHandler<MealReadyEventArgs> MealEventHandler;
    }
}