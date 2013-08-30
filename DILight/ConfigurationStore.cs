using System;
using System.Collections.Generic;
using DILight.Interfaces;

namespace DILight
{
    public class ConfigurationStore : IConfigurationStore
    {
        public IDictionary<Type, Type> _pairings;

        public IDictionary<Type, Type> Mapping<T, TK>() 
            where T : class
            where TK: class, 
            new()
        {
            _pairings = new Dictionary<Type, Type>();

            if (!_pairings.ContainsKey(typeof (T)))
            {
                _pairings.Add(typeof(T), typeof(TK));
            }

            return _pairings;
        }
    }
}
