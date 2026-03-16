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
            return CreateClient<ICoreAmazonSignin>(
                region,
                profileName,
                ServiceClientHelpers.SIGNIN_SERVICE_CLASS_FULL_NAME,
                ServiceClientHelpers.SIGNIN_SERVICE_CONFIG_FULL_NAME,
                ServiceClientHelpers.SIGNIN_ASSEMBLY_NAME,
                proxySettings,
                serviceUrl);
        }

        /// <summary>
        /// Attempts to get a service client at runtime which cannot be made a project reference.
        /// </summary>
        private static T CreateClient<T>(
            RegionEndpoint region,
            string profileName,
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceClassName,
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceConfigName,
            string parentAssemblyName,
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
                var serviceConfig = ServiceClientHelpers.CreateServiceConfig(serviceConfigName);

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

                var serviceClient = ServiceClientHelpers.CreateServiceFromTypeName<T>(
                    serviceClassName,
                    new AnonymousAWSCredentials(), serviceConfig) as T;

                return serviceClient;
            }
            catch (Exception e)
            {
                var msg = string.Format(CultureInfo.CurrentCulture,
                    "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use {1}.",
                    parentAssemblyName,
                    typeof(SigninServiceClientHelpers).AssemblyQualifiedName);

                var exception = new InvalidOperationException(msg, e);
                Logger.GetLogger(typeof(SigninServiceClientHelpers)).Error(exception, exception.Message);
                throw exception;
            }
        }
    }
}