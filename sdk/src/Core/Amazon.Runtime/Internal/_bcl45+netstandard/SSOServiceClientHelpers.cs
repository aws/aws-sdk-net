using System;
using System.Globalization;
using System.Net;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;

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
            return CreateClient<ICoreAmazonSSOOIDC>(
                region,
                ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_OIDC_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME,
                proxySettings);
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
            return CreateClient<ICoreAmazonSSO>(
                region,
                ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                ServiceClientHelpers.SSO_SERVICE_CONFIG_NAME,
                ServiceClientHelpers.SSO_ASSEMBLY_NAME,
                proxySettings);
        }

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
        private static T CreateClient<T>(
            RegionEndpoint region,
            string serviceClassName, 
            string serviceConfigName, 
            string parentAssemblyName,
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