using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Reflection;

using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
    public static class ServiceClientHelpers
    {
        public const string S3_ASSEMBLY_NAME = "AWSSDK.S3";
        public const string S3_SERVICE_CLASS_NAME = "Amazon.S3.AmazonS3Client";

        public static T CreateServiceFromAnother<T, C>(AmazonServiceClient originalServiceClient)
            where C : ClientConfig, new ()
            where T : AmazonServiceClient
        {
            var credentials = originalServiceClient.Credentials;
            var newConfig = originalServiceClient.CloneConfig<C>();

            var newServiceClientType = TypeFactory.GetTypeInfo(typeof(T));

            var constructor = newServiceClientType.GetConstructor(new ITypeInfo[]
                {
                    TypeFactory.GetTypeInfo(typeof(AWSCredentials)),
                    TypeFactory.GetTypeInfo(newConfig.GetType())
                });

            var newServiceClient = constructor.Invoke(new object[] { credentials, newConfig }) as T;

            return newServiceClient;
        }

        public static T CreateServiceFromAssembly<T>(string assemblyName, string serviceClientClassName,
            RegionEndpoint region)
            where T : class
        {
            var serviceClientType = LoadServiceClientType(assemblyName, serviceClientClassName);

            var constructor = serviceClientType.GetConstructor(new ITypeInfo[]
                {
                    TypeFactory.GetTypeInfo(typeof(RegionEndpoint))
                });

            var newServiceClient = constructor.Invoke(new object[] { region }) as T;

            return newServiceClient;
        }

        public static T CreateServiceFromAssembly<T>(string assemblyName, string serviceClientClassName, 
            AWSCredentials credentials, RegionEndpoint region)
            where T : class
        {
            var serviceClientType = LoadServiceClientType(assemblyName, serviceClientClassName);

            var constructor = serviceClientType.GetConstructor(new ITypeInfo[]
                {
                    TypeFactory.GetTypeInfo(typeof(AWSCredentials)),
                    TypeFactory.GetTypeInfo(typeof(RegionEndpoint))
                });

            var newServiceClient = constructor.Invoke(new object[] { credentials, region }) as T;

            return newServiceClient;
        }

        public static T CreateServiceFromAssembly<T>(string assemblyName, string serviceClientClassName, AmazonServiceClient originalServiceClient)
            where T : class
        {
            var serviceClientType = LoadServiceClientType(assemblyName, serviceClientClassName);

            var config = CreateServiceConfig(assemblyName, serviceClientClassName);
            originalServiceClient.CloneConfig(config);


            var constructor = serviceClientType.GetConstructor(new ITypeInfo[]
                {
                    TypeFactory.GetTypeInfo(typeof(AWSCredentials)),
                    TypeFactory.GetTypeInfo(config.GetType())
                });

            var newServiceClient = constructor.Invoke(new object[] { originalServiceClient.Credentials, config }) as T;

            return newServiceClient;
        }

        private static ITypeInfo LoadServiceClientType(string assemblyName, string serviceClientClassName)
        {
#if WIN_RT || WINDOWS_PHONE || PCL
            var assembly = Assembly.Load(new AssemblyName(assemblyName));
#else
            var assembly = Assembly.LoadFrom(assemblyName);
#endif
            if (assembly == null)
                throw new AmazonClientException(
                    string.Format(CultureInfo.InvariantCulture, "Failed to find service client {0}. Be sure to include a reference to {1}.", serviceClientClassName, assemblyName)
                    );
            var type = assembly.GetType(serviceClientClassName);

            return TypeFactory.GetTypeInfo(type);
        }

        private static ClientConfig CreateServiceConfig(string assemblyName, string serviceClientClassName)
        {
#if WIN_RT || WINDOWS_PHONE || PCL
            var assembly = Assembly.Load(new AssemblyName(assemblyName));
#else
            var assembly = Assembly.LoadFrom(assemblyName);
#endif
            if (assembly == null)
                throw new AmazonClientException(
                    string.Format(CultureInfo.InvariantCulture, "Failed to find service client {0}. Be sure to include a reference to {1}.", serviceClientClassName, assemblyName)
                    );
            var type = assembly.GetType(serviceClientClassName.Replace("Client", "Config"));

            var ci = TypeFactory.GetTypeInfo(type).GetConstructor(new ITypeInfo[0]);
            var config = ci.Invoke(new object[0]);

            return config as ClientConfig;
        }
    }
}
