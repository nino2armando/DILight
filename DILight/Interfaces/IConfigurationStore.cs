using System;
using System.Collections.Generic;

namespace DILight.Interfaces
{
    public interface IConfigurationStore
    {
        IDictionary<Type, Type> Mapping<T, TK>()
            where T : class
            where TK : class , new();
    }
}
