using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.CompilerServices;
using Amazon.Util.Internal;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime.Internal
{
    public static class ServiceClientHelpers
    {
        public const string S3_ASSEMBLY_NAME = "AWSSDK.S3";
        public const string S3_SERVICE_CLASS_NAME = "Amazon.S3.AmazonS3Client";

        public const string SSO_ASSEMBLY_NAME = "AWSSDK.SSO";
        public const string SSO_SERVICE_CLASS_NAME = "Amazon.SSO.AmazonSSOClient";
        public const string SSO_SERVICE_CONFIG_NAME = "Amazon.SSO.AmazonSSOConfig";

        public const string SSO_OIDC_ASSEMBLY_NAME = "AWSSDK.SSOOIDC";
        public const string SSO_OIDC_SERVICE_CLASS_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCClient";
        public const string SSO_OIDC_SERVICE_CONFIG_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCConfig";

        public const string STS_ASSEMBLY_NAME = "AWSSDK.SecurityToken";
        public const string STS_SERVICE_CLASS_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient";
        public const string STS_SERVICE_CONFIG_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig";

        public static TClient CreateServiceFromAnother<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TClient, 
                                    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TConfig>(AmazonServiceClient originalServiceClient)
            where TConfig : ClientConfig, new ()
            where TClient : AmazonServiceClient
        {
            var credentials = originalServiceClient.ExplicitAWSCredentials ?? originalServiceClient.Config.DefaultAWSCredentials;
            var newConfig = originalServiceClient.CloneConfig<TConfig>();

            var newServiceClientTypeInfo = typeof(TClient);

            var constructor = newServiceClientTypeInfo.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    newConfig.GetType()
                });

            var newServiceClient = constructor.Invoke(new object[] { credentials, newConfig }) as TClient;

            return newServiceClient;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code should use Amazon.RuntimeDependencyRegistry to use explicitly provided runtime dependencies.")]
        public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName,
            RegionEndpoint region)
            where TClient : class
        {
            var serviceClientTypeInfo = LoadServiceClientType(assemblyName, serviceClientClassName);

            var constructor = serviceClientTypeInfo.GetConstructor(new Type[]
                {
                    typeof(RegionEndpoint)
                });

            var newServiceClient = constructor.Invoke(new object[] { region }) as TClient;

            return newServiceClient;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code should use Amazon.RuntimeDependencyRegistry to use explicitly provided runtime dependencies.")]
        public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, 
            AWSCredentials credentials, RegionEndpoint region)
            where TClient : class
        {
            var serviceClientTypeInfo = LoadServiceClientType(assemblyName, serviceClientClassName);

            var constructor = serviceClientTypeInfo.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    typeof(RegionEndpoint)
                });

            var newServiceClient = constructor.Invoke(new object[] { credentials, region }) as TClient;

            return newServiceClient;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code should use Amazon.RuntimeDependencyRegistry to use explicitly provided runtime dependencies.")]
        public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName,
            AWSCredentials credentials, ClientConfig config)
            where TClient : class
        {
            var serviceClientTypeInfo = LoadServiceClientType(assemblyName, serviceClientClassName);
        
            var constructor = serviceClientTypeInfo.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    config.GetType()
                });

            var newServiceClient = constructor.Invoke(new object[] { credentials, config }) as TClient;

            return newServiceClient;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code should use Amazon.RuntimeDependencyRegistry to use explicitly provided runtime dependencies.")]
        public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AmazonServiceClient originalServiceClient)
            where TClient : class
        {
            var serviceClientTypeInfo = LoadServiceClientType(assemblyName, serviceClientClassName);

            var config = CreateServiceConfig(assemblyName, serviceClientClassName.Replace("Client", "Config"));
            originalServiceClient.CloneConfig(config);

            var constructor = serviceClientTypeInfo.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    config.GetType()
                });

            var credentials = originalServiceClient.ExplicitAWSCredentials ?? originalServiceClient.Config.DefaultAWSCredentials;
            var newServiceClient = constructor.Invoke(new object[] { credentials, config }) as TClient;

            return newServiceClient;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        public static ClientConfig CreateServiceConfig(string assemblyName, string serviceConfigClassName)
        {
            var typeInfo = LoadServiceConfigType(assemblyName, serviceConfigClassName);

            var ci = typeInfo.GetConstructor(new Type[0]);
            var config = ci.Invoke(new object[0]);

            return config as ClientConfig;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        private static Type LoadServiceClientType(string assemblyName, string serviceClientClassName)
        {
            return LoadTypeFromAssembly(assemblyName, serviceClientClassName);
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        private static Type LoadServiceConfigType(string assemblyName, string serviceConfigClassName)
        {
            return LoadTypeFromAssembly(assemblyName, serviceConfigClassName);
        }

    [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        internal static Type LoadTypeFromAssembly(string assemblyName, string className)
        {
            var assembly = GetSDKAssembly(assemblyName);
            var type = assembly.GetType(className);

            return type;
        }

        [RequiresUnreferencedCode("Using ServiceClientHelper to dynamically load dependency is not supported for Native AOT. SDK calling code must use Amazon.RuntimeDependencyRegistry to explicitly provide runtime dependencies.")]
        private static Assembly GetSDKAssembly(string assemblyName)
        {
            return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => string.Equals(x.GetName().Name, assemblyName, StringComparison.Ordinal))
                ?? Assembly.Load(new AssemblyName(assemblyName))
                ?? throw new AmazonClientException($"Failed to load assembly. Be sure to include a reference to {assemblyName}.");
        }
    }
}
