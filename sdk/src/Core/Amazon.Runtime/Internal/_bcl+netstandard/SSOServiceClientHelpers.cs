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
    /// interrogate AWS SSO Services.
    /// </summary>
    [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
        Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
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
            ICoreAmazonSSOOIDC coreSSO = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSOOIDC>(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOOIDCClientContext { Region = region, ProxySettings = proxySettings }));
            if (coreSSO == null)
            {
                coreSSO = CreateClient<ICoreAmazonSSOOIDC>(
                    region,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOOIDCClient),
                    proxySettings);
            }

            return coreSSO;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        public static ICoreAmazonSSO BuildSSOClient(
            RegionEndpoint region,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            ICoreAmazonSSO coreSSO = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSO>(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOClientContext { Region = region, ProxySettings = proxySettings }));
            if(coreSSO == null)
            {
                coreSSO = CreateClient<ICoreAmazonSSO>(
                    region,
                    ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOClient),
                    proxySettings);
            }
            return coreSSO;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        public static ICoreAmazonSSO_Logout BuildSSOLogoutClient(
            RegionEndpoint region,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            ICoreAmazonSSO_Logout coreSSOLogout = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSO_Logout>(ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOClientContext { Region = region, ProxySettings = proxySettings }));
            if(coreSSOLogout == null)
            {
                coreSSOLogout = CreateClient<ICoreAmazonSSO_Logout>(
                    region,
                    ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOClient),
                    proxySettings);
            }
            return coreSSOLogout;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        public static ICoreAmazonSSOOIDC_V2 BuildSSOIDC_V2Client(
            RegionEndpoint region,
#if BCL
            WebProxy proxySettings = null
#elif NETSTANDARD
            IWebProxy proxySettings = null
#endif
        )
        {
            ICoreAmazonSSOOIDC_V2 coreSSO = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonSSOOIDC_V2>(ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME, new CreateInstanceContext(new SSOOIDCClientContext { Region = region, ProxySettings = proxySettings }));
            if (coreSSO == null)
            {
                coreSSO = CreateClient<ICoreAmazonSSOOIDC_V2>(
                    region,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                    ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                    ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME,
                    nameof(GlobalRuntimeDependencyRegistry.RegisterSSOOIDCClient),
                    proxySettings);
            }

            return coreSSO;
        }

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
    [RequiresUnreferencedCode("Using CreateClient to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
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