using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace YSH.Framework.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceTypeAttribute : System.Attribute
    {
        public ServiceLifetime _serviceLifetime;
        public Type _interfaceType;

        public ServiceTypeAttribute(ServiceLifetime serviceLifetime, Type interfaceType)
        {
            _serviceLifetime = serviceLifetime;
            _interfaceType = interfaceType;
        }
    }
}
