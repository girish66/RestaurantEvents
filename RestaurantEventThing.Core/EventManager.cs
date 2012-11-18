using System;
using System.Collections.Generic;

namespace RestaurantEventThing.Core
{
    //marker interface for now


    public class EventManager
    {
        [ThreadStatic] private static List<Delegate> _actions;


        public static void Register<T>(Action<T> processEvent) where T:IDomainEvent
        {
            if (_actions == null) _actions = new List<Delegate>();
            _actions.Add(processEvent);
        }


        public static void Raise<T>(T args) where T : IDomainEvent
        {
            foreach (var action in _actions)
            {
                if (action is Action<T>)
                {
                    ((Action<T>)action).Invoke(args);
                }
            }
        }
    }
}