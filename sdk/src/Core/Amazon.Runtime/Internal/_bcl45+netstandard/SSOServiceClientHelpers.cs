using System;
using System.Globalization;
using System.Net;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencyRegistry;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Collection of helper methods for constructing the necessary Service client to
    /// interrogate AWS SSO Services.
    /// </summary>
    public static class SSOServiceClientHelpers
    {
        public static ICoreAmazonSSOOIDC BuildSSOIDCClient(
            RegionEndpoint region,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            ICoreAmazonSSOOIDC coreSSO = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSOOIDC>(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOOIDCClientContext(region)));
            if (coreSSO == null)
            {
#pragma warning disable IL2026,IL2075
                coreSSO = CreateClient<ICoreAmazonSSOOIDC>(
                    region,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOOIDCClient),
                    proxySettings);
#pragma warning restore IL2026,IL2075
            }

            return coreSSO;
        }

        public static ICoreAmazonSSO BuildSSOClient(
            RegionEndpoint region,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            ICoreAmazonSSO coreSSO = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSO>(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOClientContext(region)));
            if(coreSSO == null)
            {
#pragma warning disable IL2026,IL2075
                coreSSO = CreateClient<ICoreAmazonSSO>(
                    region,
                    ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOClient),
                    proxySettings);
#pragma warning restore IL2026,IL2075
            }
            return coreSSO;
        }

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
#if NET6_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("Using CreateClient to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
#endif
        private static T CreateClient<T>(
        RegionEndpoint region,
            string serviceClassName, 
            string serviceConfigName, 
            string parentAssemblyName,
            string runtimeDependencyRegistryMethod,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        ) 
            where T : class
        {
            try
            {
                var serviceConfig = ServiceClientHelpers.CreateServiceConfig(
                    parentAssemblyName,
                    serviceConfigName);

                serviceConfig.RegionEndpoint = region;

                if (null != proxySettings)
                {
                    serviceConfig.SetWebProxy(proxySettings);
                }

                var serviceClient = ServiceClientHelpers.CreateServiceFromAssembly<T>(
                    parentAssemblyName,
                    serviceClassName,
                    new AnonymousAWSCredentials(), serviceConfig) as T;

                return serviceClient;
            }
            catch (Exception e)
            {
                if (InternalSDKUtils.IsRunningNativeAot())
                {
                    throw new MissingRuntimeDependencyException(parentAssemblyName, serviceClassName, runtimeDependencyRegistryMethod);
                }

                var msg = string.Format(CultureInfo.CurrentCulture,
                    "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use {1}.",
                    parentAssemblyName,
                    typeof(SSOServiceClientHelpers).AssemblyQualifiedName);

                var exception = new InvalidOperationException(msg, e);
                Logger.GetLogger(typeof(SSOServiceClientHelpers)).Error(exception, exception.Message);
                throw exception;
            }
        }
    }
}