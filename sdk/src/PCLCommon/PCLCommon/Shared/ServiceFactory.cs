using System;
using System.Collections.Generic;

namespace Amazon.Common
{
    public class ServiceFactory
    {
        enum InstantiationModel
        {
            Singleton,
            InstancePerCall
        }

        private readonly object _lock = new object();
        private IDictionary<Type, Type> _mappings = 
            new Dictionary<Type, Type>()
            {
                {typeof(IApplicationSettings),typeof(ApplicationSettings)},
                {typeof(INetworkReachability),typeof(NetworkReachability)}
            };

        private IDictionary<Type, InstantiationModel> _instantationMappings = 
            new Dictionary<Type, InstantiationModel>()
            {
                {typeof(IApplicationSettings), InstantiationModel.InstancePerCall},
                {typeof(INetworkReachability), InstantiationModel.Singleton}
            };

        private ServiceFactory()
        {

        }

        public void RegisterService<T>(Type serviceType)
        {
            lock (_lock)
            {
                _mappings[typeof(T)] = serviceType;
            }
        }

        public T GetService<T>()
        {
            var concreteType = GetServiceType<T>();
            return (T)Activator.CreateInstance(concreteType);
        }

        public T GetService<T>(params object[] constructorArgs)
        {
            var concreteType = GetServiceType<T>();
            return (T)Activator.CreateInstance(concreteType, constructorArgs);
        }

        private Type GetServiceType<T>()
        {
            lock (_lock)
            {
                return _mappings[typeof(T)];
            }
        }
    }
}
