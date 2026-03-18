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
        public const string S3_SERVICE_CLASS_FULL_NAME = "Amazon.S3.AmazonS3Client, AWSSDK.S3";
        public const string S3_CONFIG_CLASS_FULL_NAME = "Amazon.S3.AmazonS3Config, AWSSDK.S3";

        public const string SSO_ASSEMBLY_NAME = "AWSSDK.SSO";
        public const string SSO_SERVICE_CLASS_NAME = "Amazon.SSO.AmazonSSOClient";
        public const string SSO_SERVICE_CONFIG_NAME = "Amazon.SSO.AmazonSSOConfig";
        internal const string SSO_SERVICE_CLASS_FULL_NAME = "Amazon.SSO.AmazonSSOClient, AWSSDK.SSO";
        internal const string SSO_SERVICE_CONFIG_FULL_NAME = "Amazon.SSO.AmazonSSOConfig, AWSSDK.SSO";

        public const string SSO_OIDC_ASSEMBLY_NAME = "AWSSDK.SSOOIDC";
        public const string SSO_OIDC_SERVICE_CLASS_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCClient";
        public const string SSO_OIDC_SERVICE_CONFIG_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCConfig";
        internal const string SSO_OIDC_SERVICE_CLASS_FULL_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCClient, AWSSDK.SSOOIDC";
        internal const string SSO_OIDC_SERVICE_CONFIG_FULL_NAME = "Amazon.SSOOIDC.AmazonSSOOIDCConfig, AWSSDK.SSOOIDC";

        public const string SIGNIN_ASSEMBLY_NAME = "AWSSDK.Signin";
        public const string SIGNIN_SERVICE_CLASS_NAME = "Amazon.Signin.AmazonSigninClient";
        public const string SIGNIN_SERVICE_CONFIG_NAME = "Amazon.Signin.AmazonSigninConfig";
        internal const string SIGNIN_SERVICE_CLASS_FULL_NAME = "Amazon.Signin.AmazonSigninClient, AWSSDK.Signin";
        internal const string SIGNIN_SERVICE_CONFIG_FULL_NAME = "Amazon.Signin.AmazonSigninConfig, AWSSDK.Signin";

        public const string STS_ASSEMBLY_NAME = "AWSSDK.SecurityToken";
        public const string STS_SERVICE_CLASS_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient";
        public const string STS_SERVICE_CONFIG_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig";
        internal const string STS_SERVICE_CLASS_FULL_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient, AWSSDK.SecurityToken";
        internal const string STS_SERVICE_CONFIG_FULL_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig, AWSSDK.SecurityToken";

        public static TClient CreateServiceFromAnother<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TClient,
                                    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TConfig>(AmazonServiceClient originalServiceClient)
            where TConfig : ClientConfig, new()
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

            var newServiceClient = (TClient)constructor.Invoke(new object[] { credentials, newConfig });

            return newServiceClient;
        }

        internal static TClient CreateServiceFromTypeName<TClient>(
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceClientName,
            AWSCredentials credentials, ClientConfig config)
            where TClient : class
        {
            var serviceClientType = Type.GetType(serviceClientName);
            if (serviceClientType is null)
            {
                ThrowTypeNotAvailable(serviceClientName);
            }

            var constructor = serviceClientType.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    config.GetType()
                });

            var newServiceClient = (TClient)constructor.Invoke(new object[] { credentials, config });

            return newServiceClient;
        }

        internal static TClient CreateServiceFromTypeName<TClient>(
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceClientName,
            AWSCredentials credentials, RegionEndpoint region)
            where TClient : class
        {
            var serviceClientType = Type.GetType(serviceClientName);
            if (serviceClientType is null)
            {
                ThrowTypeNotAvailable(serviceClientName);
            }

            var constructor = serviceClientType.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    typeof(RegionEndpoint)
                });

            var newServiceClient = (TClient)constructor.Invoke(new object[] { credentials, region });

            return newServiceClient;
        }

        public static TClient CreateServiceFromTypeName<TClient>(
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceClientName,
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
#endif
            string serviceConfigName,
            AmazonServiceClient originalServiceClient)
            where TClient : class
        {
            var serviceClientType = Type.GetType(serviceClientName);
            if (serviceClientType is null)
            {
                ThrowTypeNotAvailable(serviceClientName);
            }

            var config = CreateServiceConfig(serviceConfigName);
            originalServiceClient.CloneConfig(config);

            var constructor = serviceClientType.GetConstructor(new Type[]
                {
                    typeof(AWSCredentials),
                    config.GetType()
                });

            var credentials = originalServiceClient.ExplicitAWSCredentials ?? originalServiceClient.Config.DefaultAWSCredentials;
            var newServiceClient = constructor.Invoke(new object[] { credentials, config }) as TClient;

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

        internal static ClientConfig CreateServiceConfig(
#if NET
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
#endif
            string typeName)
        {
            var type = Type.GetType(typeName);
            if (type is null)
            {
                ThrowTypeNotAvailable(typeName);
            }

            var config = Activator.CreateInstance(type);

            return (ClientConfig)config;
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

#if NET
        [DoesNotReturn]
#endif
        private static void ThrowTypeNotAvailable(string assemblyQualifiedTypeName)
        {
            int idxOfComma = assemblyQualifiedTypeName.IndexOf(',');
            string assemblyName = idxOfComma >= 0 ? assemblyQualifiedTypeName.Substring(idxOfComma + 1).Trim() : assemblyQualifiedTypeName;
            throw new AmazonClientException($"Failed to load assembly. Be sure to include a reference to {assemblyName}.");
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
