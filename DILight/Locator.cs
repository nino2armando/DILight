using System;
using System.Collections.Generic;
using DILight.Interfaces;

namespace DILight
{
    public static class Locator 
    {

        public static T Resolve<T>(IDictionary<Type, Type> pairings) where T: class
        {
            T obj = null;

            if (pairings.ContainsKey(typeof (T)))
            {
                Type temp;
                pairings.TryGetValue(typeof (T), out temp);

                if (temp != null) obj = (T) Activator.CreateInstance(temp);
            }
            return obj;
        }     

    }
}
