using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using AWSSDK.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon.RuntimeDependencyRegistry
{
    public delegate object RuntimeDependencyFactory(CreateInstanceContext context);

    public class CreateInstanceContext
    {
        public enum ContextType { SecurityTokenServiceClient, KeyManagementServiceClient, SigV4aCrtSigner, CheckSumProvider, SSOClient, SSOOIDCClient }

        public CreateInstanceContext(SecurityTokenServiceClientContext context)
        {
            SecurityTokenServiceClientContextData = context;
            Type = ContextType.SecurityTokenServiceClient;
        }

        public CreateInstanceContext(KeyManagementServiceClientContext context)
        {
            KeyManagementServiceClientContextData = context;
            Type = ContextType.KeyManagementServiceClient;
        }

        public CreateInstanceContext(SigV4aCrtSignerContext context)
        {
            SigV4aCrtSignerContextData = context;
            Type = ContextType.SigV4aCrtSigner;
        }

        public CreateInstanceContext(CheckSumProviderContext context)
        {
            CheckSumProviderContextData = context;
            Type = ContextType.CheckSumProvider;
        }

        public CreateInstanceContext(SSOClientContext context)
        {
            SSOClientContextData = context;
            Type = ContextType.SSOClient;
        }

        public CreateInstanceContext(SSOOIDCClientContext context)
        {
            SSOOIDCClientContextData = context;
            Type = ContextType.SSOOIDCClient;
        }

        public ContextType Type { get; }

        public SecurityTokenServiceClientContext SecurityTokenServiceClientContextData { get; }

        public KeyManagementServiceClientContext KeyManagementServiceClientContextData { get; }

        public SigV4aCrtSignerContext SigV4aCrtSignerContextData { get; }

        public CheckSumProviderContext CheckSumProviderContextData { get; }

        public SSOClientContext SSOClientContextData { get; }

        public SSOOIDCClientContext SSOOIDCClientContextData { get; }
    }



    public class SecurityTokenServiceClientContext
    {
        public enum SourceContext { AssumeRoleAWSCredentials, AssumeRoleWithWebIdentityCredentials, FederatedAWSCredentials };

        public SecurityTokenServiceClientContext(SourceContext source, RegionEndpoint region)
        {
            Source = source;
            Region = region;
        }

        public SourceContext Source { get; }

        public RegionEndpoint Region { get; }
    }

    public class KeyManagementServiceClientContext
    {
        public KeyManagementServiceClientContext(AmazonServiceClient parentServiceClient)
        {
            ParentServiceClient = parentServiceClient;
        }

        public AmazonServiceClient ParentServiceClient { get; }
    }

    public class SigV4aCrtSignerContext
    {
        public SigV4aCrtSignerContext(bool payload)
        {
            Payload = payload;
        }

        public bool Payload { get; }
    }

    public class CheckSumProviderContext
    {

    }

    public class SSOClientContext
    {
        public SSOClientContext(RegionEndpoint region)
        {
            Region = region;
        }

        public RegionEndpoint Region { get; }
    }

    public class SSOOIDCClientContext
    {
        public SSOOIDCClientContext(RegionEndpoint region)
        {
            Region = region;
        }

        public RegionEndpoint Region { get; }
    }


    public abstract class AbstractRuntimeDependencyRegistry : IDisposable
    {
        private ReaderWriterLockSlim _rwlock = new ReaderWriterLockSlim();
        private IDictionary<string, RuntimeDependencyFactory> _runtimeDependency = new Dictionary<string, RuntimeDependencyFactory>();
        private bool _disposedValue;

        protected void RegisterInstance(string assemblyName, string className, object instance)
        {
            RegisterInstance(assemblyName, className, (context) => instance);
        }

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

        private string FormatKey(string assemblyName, string className) => $"{assemblyName}_{className}";

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

    public class ServiceClientRuntimeDependencyRegistry : AbstractRuntimeDependencyRegistry
    {
        internal ServiceClientRuntimeDependencyRegistry() { }

        /// <summary>
        /// Register the Amazon.KeyManagementService.AmazonKeyManagementServiceClient instance from AWSSDK.KeyManagementService package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterKeyManagementServiceClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.KMS_ASSEMBLY_NAME, ServiceClientHelpers.KMS_SERVICE_CLASS_NAME, (o) => instance);
        }

        /// <summary>
        /// Register the Amazon.KeyManagementService.AmazonKeyManagementServiceClient instance from AWSSDK.KeyManagementService package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterKeyManagementServiceClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.KMS_ASSEMBLY_NAME, ServiceClientHelpers.KMS_SERVICE_CLASS_NAME, factory);
        }

        public override T GetInstance<T>(string assemblyName, string className, CreateInstanceContext context)
        {
            var instance = base.GetInstance<T>(assemblyName, className, context);
            if(instance == null)
            {
                instance = GlobalRuntimeDependencyRegistry.Instance.GetInstance<T>(assemblyName, className, context);
            }

            return instance;
        }
    }

    /// <summary>
    /// There are some features of the AWS .NET SDK that at runtime load dependencies from assemblies. The most common
    /// example is using credential profiles that require the service client from the AWSSDK.SecurityToken package.
    /// Normally these runtime dependencies are resolved by using reflection to load the assembly and the type,
    /// In Native AOT with trimming turned on that will not worked because the dependency would be trimmed out.
    /// 
    /// The RuntimeDependencyRegistry is used to work around this limitation by allowing users to explicitly register
    /// the runtime dependency instance into the SDK removing any use of reflection.
    /// </summary>
    public class GlobalRuntimeDependencyRegistry : AbstractRuntimeDependencyRegistry
    {
        private static readonly GlobalRuntimeDependencyRegistry _instance = new GlobalRuntimeDependencyRegistry();
        public static GlobalRuntimeDependencyRegistry Instance { get { return _instance; } }

        internal GlobalRuntimeDependencyRegistry() 
        { 
        }

        /// <summary>
        /// Register the Checksum provider. This should be an instance of AWSSDK.Extensions.CrtIntegration.CrtChecksums from AWSSDK.Extensions.CrtIntegration package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterChecksumProvider(object instance)
        {
            RegisterInstance(ChecksumCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, ChecksumCRTWrapper.CRT_WRAPPER_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the AWS SigV4a provider. This should be an instance of Amazon.Extensions.CrtIntegration.CrtAWS4aSigner from AWSSDK.Extensions.CrtIntegration package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSigV4aProvider(RuntimeDependencyFactory factory)
        {
            RegisterInstance(AWS4aSignerCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, AWS4aSignerCRTWrapper.CRT_WRAPPER_CLASS_NAME, factory);
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
        /// Register the Amazon.KeyManagementService.AmazonKeyManagementServiceClient instance from AWSSDK.KeyManagementService package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterKeyManagementServiceClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.KMS_ASSEMBLY_NAME, ServiceClientHelpers.KMS_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSecurityTokenServiceClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SecurityToken.AmazonSecurityTokenServiceClient instance from the AWSSDK.SecurityToken package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSecurityTokenServiceClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SSO.AmazonSSOClient instance from the AWSSDK.SSO package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSSOClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SSO.AmazonSSOClient instance from the AWSSDK.SSO package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSSOClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, factory);
        }

        /// <summary>
        /// Register the Amazon.SSOOIDC.AmazonSSOOIDCClient instance from the AWSSDK.SSOOIDC package.
        /// </summary>
        /// <param name="instance"></param>
        public void RegisterSSOOIDCClient(object instance)
        {
            RegisterInstance(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, instance);
        }

        /// <summary>
        /// Register the Amazon.SSOOIDC.AmazonSSOOIDCClient instance from the AWSSDK.SSOOIDC package.
        /// </summary>
        /// <param name="factory"></param>
        public void RegisterSSOOIDCClient(RuntimeDependencyFactory factory)
        {
            RegisterInstance(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, factory);
        }
    }

    /// <summary>
    /// This exception is thrown when the SDK is used as part of an application compiled for Native AOT with trimming turned on.
    /// In this environment assemblies can not be dynamically loaded and the usual ServiceClientHelpers operations will fail.
    /// </summary>
    public class MissingRuntimeDependencyException : AmazonClientException
    {

        public MissingRuntimeDependencyException(string packageName, string className, string registerMethod)
            : base("Operation failed because of a missing runtime dependency. In Native AOT builds runtime dependencies can not be " +
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
