/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon.RuntimeDependencies
{
    /// <summary>
    /// Factory delegate registered by the SDK user into the runtime dependency registry. The registry will invoke the delegate
    /// when an instance of the registered type is needed.
    /// </summary>
    /// <param name="context">Context information the SDK user registering the callback can use to construct the object.</param>
    /// <returns>An instance for the registered type in the registry.</returns>
    public delegate object RuntimeDependencyFactory(CreateInstanceContext context);

    /// <summary>
    /// Base runtime dependency registry managing the state of the registry and invoking any registered RuntimeDependencyFactory callbacks.
    /// </summary>
    public abstract class BaseRuntimeDependencyRegistry : IDisposable
    {
        private ReaderWriterLockSlim _rwlock = new ReaderWriterLockSlim();
        private IDictionary<string, RuntimeDependencyFactory> _runtimeDependency = new Dictionary<string, RuntimeDependencyFactory>();
        private bool _disposedValue;

        /// <summary>
        /// Register the object for the assemblyName and className.
        /// </summary>
        /// <param name="assemblyName">The assembly of the instance.</param>
        /// <param name="className">The class name of the instance.</param>
        /// <param name="instance">The instance to use for the runtime dependency.</param>
        protected void RegisterInstance(string assemblyName, string className, object instance)
        {
            RegisterInstance(assemblyName, className, (context) => instance);
        }

        /// <summary>
        /// Register the RuntimeDependencyFactory to create the runtime dependency for the assemblyName and className.
        /// </summary>
        /// <param name="assemblyName">The assembly of the instance.</param>
        /// <param name="className">The class name of the instance.</param>
        /// <param name="factory">The factory to create the runtime dependency.</param>
        protected void RegisterInstance(string assemblyName, string className, RuntimeDependencyFactory factory)
        {
            try
            {
                _rwlock.EnterWriteLock();

                _runtimeDependency[FormatKey(assemblyName, className)] = factory;
            }
            finally
            {
                if (_rwlock.IsWriteLockHeld)
                {
                    _rwlock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Get the registerd runtime dependency instance. This method is used by the SDK's core package and for service packages 
        /// to get a reference to another service package service client.
        /// </summary>
        /// <typeparam name="T">The type that should be returned from the registry.</typeparam>
        /// <param name="assemblyName"></param>
        /// <param name="className"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual T GetInstance<T>(string assemblyName, string className, CreateInstanceContext context)
            where T : class
        {
            try
            {
                _rwlock.EnterReadLock();

                if (_runtimeDependency.TryGetValue(FormatKey(assemblyName, className), out RuntimeDependencyFactory factory))
                {
                    return factory(context) as T;
                }

                return null;
            }
            finally
            {
                if (_rwlock.IsReadLockHeld)
                {
                    _rwlock.ExitReadLock();
                }
            }
        }

        private static string FormatKey(string assemblyName, string className) => $"{assemblyName}_{className}";

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _rwlock.Dispose();
                }

                _disposedValue = true;
            }
        }

        /// <summary>
        /// Dispose the instance.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
