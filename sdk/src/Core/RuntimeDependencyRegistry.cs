using Amazon.Runtime;
using Amazon.Runtime.Internal;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon
{
    /// <summary>
    /// Their are some features of the AWS .NET SDK that at runtime load dependencies from assemblies. The most common
    /// example is using credential profiles that require the service client from the AWSSDK.SecurityToken package.
    /// Normally these runtime dependencies are resolved by using reflection to load the assembly and the type,
    /// In Native AOT with trimming turned on that will not worked because the dependency would be trimmed out.
    /// 
    /// The RuntimeDependencyRegistry is used to work around this limitation by allowing users to explicitly register
    /// the runtime dependency instance into the SDK removing any use of reflection.
    /// </summary>
    public class RuntimeDependencyRegistry : IDisposable
    {
        private static readonly RuntimeDependencyRegistry _instance = new RuntimeDependencyRegistry();
        public static RuntimeDependencyRegistry Instance { get { return _instance; } }

        internal RuntimeDependencyRegistry() 
        { 
        }

        private ReaderWriterLockSlim _rwlock = new ReaderWriterLockSlim();
        private IDictionary<string, object> _runtimeDependency = new Dictionary<string, object>();
        private bool disposedValue;

        /// <summary>
        /// Register the Checksum provider. This should be an instance of AWSSDK.Extensions.CrtIntegration.CrtChecksums from AWSSDK.Extensions.CrtIntegration package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterChecksumProvider(object instance)
        {
            RegisterInstance(ChecksumCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, ChecksumCRTWrapper.CRT_WRAPPER_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.KeyManagementService.AmazonKeyManagementServiceClient instance from AWSSDK.KeyManagementService package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterKeyManagementServiceClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.KMS_ASSEMBLY_NAME, ServiceClientHelpers.KMS_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSecurityTokenServiceClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, instance);
        }

        private void RegisterInstance(string assemblyName, string className, object instance)
        {
            try
            {
                _rwlock.EnterWriteLock();

                _runtimeDependency[FormatKey(assemblyName, className)] = instance;
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
        /// <returns></returns>
        public T GetInstance<T>(string assemblyName, string className)
            where T : class
        {
            try
            {
                _rwlock.EnterReadLock();

                if (_runtimeDependency.TryGetValue(FormatKey(assemblyName, className), out object instance))
                {
                    return instance as T;
                }

                return null;
            }
            finally
            {
                if(_rwlock.IsReadLockHeld)
                {
                    _rwlock.ExitReadLock();
                }
            }
        }

        private string FormatKey(string assemblyName, string className) => $"{assemblyName}_{className}";

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _rwlock.Dispose();
                }

                disposedValue = true;
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

    /// <summary>
    /// This exception is thrown when the SDK is used as part of an application compiled for Native AOT with trimming turned on.
    /// In this environment assemblies can not be dynamically loaded and the usual ServiceClientHelpers operations will fail.
    /// </summary>
    public class MissingRuntimeDependencyException : AmazonClientException
    {

        public MissingRuntimeDependencyException(string packageName, string className, string registerMethod)
            : base("Operation failed because of missing runtime dependency. In Native AOT builds runtime dependencies can not be " +
                  "dynamically loaded from assembles. Instead the runtime dependency needs to be explicitly registered. " +
                  $"To complete this operation register an instance of {className} from package {packageName} using the " +
                  $"operation Amazon.RuntimeDependencyRegistry.Instance.{registerMethod}.")
        {
            this.PackageName = packageName;
            this.ClassName = className;
            this.RegisterMethod = registerMethod;
        }

        /// <summary>
        /// The package containing the runtime dependency
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// The class that must be instantiated and registered to Amazon.RuntimeDependencyRegistry
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// The method on Amazon.RuntimeDependencyRegistry that should be called with an instance of the type referred by the ClassName property.
        /// </summary>
        public string RegisterMethod { get; set; }
    }
}
