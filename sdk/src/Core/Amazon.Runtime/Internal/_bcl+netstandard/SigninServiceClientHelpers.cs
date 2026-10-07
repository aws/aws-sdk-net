using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.Util.Internal;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Collection of helper methods for constructing the necessary Service client to
    /// interrogate AWS Signin Service.
    /// </summary>
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
        Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
    public static class SigninServiceClientHelpers
    {
        public static ICoreAmazonSignin BuildSigninClient(
            RegionEndpoint region,
            string profileName,
#if BCL
            WebProxy proxySettings = null,
#elif NETSTANDARD
            IWebProxy proxySettings = null,
#endif
            string serviceUrl = null
        )
        {
            ICoreAmazonSignin coreSignin = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSignin>(ServiceClientHelpers.SIGNIN_ASSEMBLY_NAME, ServiceClientHelpers.SIGNIN_SERVICE_CLASS_NAME, new CreateInstanceContext(new SigninClientContext { Region = region, ProfileName = profileName, ProxySettings = proxySettings, ServiceURL = serviceUrl }));
            if (coreSignin == null)
            {
                coreSignin = CreateClient<ICoreAmazonSignin>(
                    region,
                    profileName,
                    ServiceClientHelpers.SIGNIN_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SIGNIN_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SIGNIN_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSigninClient),
                    proxySettings,
                    serviceUrl);
            }

            return coreSignin;
        }

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
        [RequiresUnreferencedCode("Using CreateClient to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        private static T CreateClient<T>(
            RegionEndpoint region,
            string profileName,
            string serviceClassName, 
            string serviceConfigName, 
            string parentAssemblyName,
            string runtimeDependencyRegistryMethod,
#if BCL
            WebProxy proxySettings = null,
#elif NETSTANDARD
            IWebProxy proxySettings = null,
#endif
            string serviceUrl = null
        ) 
            where T : class
        {
            try
            {
                var serviceConfig = ServiceClientHelpers.CreateServiceConfig(
                    parentAssemblyName,
                    serviceConfigName);

                serviceConfig.RegionEndpoint = region;

                if (!string.IsNullOrEmpty(profileName))
                {
                    serviceConfig.Profile = new Profile(profileName);
                }

                if (null != proxySettings)
                {
                    serviceConfig.SetWebProxy(proxySettings);
                }

                if (null != serviceUrl)
                {
                    serviceConfig.ServiceURL = serviceUrl;
                }

                var serviceClient = ServiceClientHelpers.CreateServiceFromAssembly<T>(
                    parentAssemblyName,
                    serviceClassName,
                    new AnonymousAWSCredentials(), serviceConfig) as T;

                return serviceClient;
            }
            catch (Exception e)
            {
                throw CreateMissingDependencyException(e, parentAssemblyName, serviceClassName, runtimeDependencyRegistryMethod);
            }
        }

        /// <summary>
        /// Throws if the Signin client cannot be resolved, without creating a client or requiring a region.
        /// </summary>
        internal static void EnsureSigninClientAvailable()
        {
            EnsureClientAvailable(ServiceClientHelpers.SIGNIN_ASSEMBLY_NAME, ServiceClientHelpers.SIGNIN_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SIGNIN_SERVICE_CONFIG_NAME, nameof(GlobalRuntimeDependencyRegistry.RegisterSigninClient));
        }

        internal static void EnsureClientAvailable(string assemblyName, string serviceClassName,
            string serviceConfigName, string runtimeDependencyRegistryMethod)
        {
            if (GlobalRuntimeDependencyRegistry.Instance.IsRegistered(assemblyName, serviceClassName))
                return;

            try
            {
                ServiceClientHelpers.CreateServiceConfig(assemblyName, serviceConfigName);
            }
            catch (Exception e)
            {
                throw CreateMissingDependencyException(e, assemblyName, serviceClassName, runtimeDependencyRegistryMethod);
            }
        }

        private static Exception CreateMissingDependencyException(Exception e, string parentAssemblyName,
            string serviceClassName, string runtimeDependencyRegistryMethod)
        {
            if (InternalSDKUtils.IsRunningNativeAot())
            {
                return new MissingRuntimeDependencyException(parentAssemblyName, serviceClassName, runtimeDependencyRegistryMethod);
            }

            var msg = string.Format(CultureInfo.CurrentCulture,
                "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use {1}.",
                parentAssemblyName,
                typeof(SigninServiceClientHelpers).AssemblyQualifiedName);

            var exception = new InvalidOperationException(msg, e);
            Logger.GetLogger(typeof(SigninServiceClientHelpers)).Error(exception, exception.Message);
            return exception;
        }
    }
}