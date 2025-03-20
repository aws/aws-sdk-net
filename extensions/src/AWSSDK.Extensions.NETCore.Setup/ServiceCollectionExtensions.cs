/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using Amazon.Runtime;
using Amazon.Extensions.NETCore.Setup;
using AWSSDK.Extensions.NETCore.Setup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// This class adds extension methods to IServiceCollection making it easier to add Amazon service clients
    /// to the NET Core dependency injection framework.
    /// </summary>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(Amazon.Extensions.NETCore.Setup.InternalConstants.RequiresUnreferencedCodeMessage)]
#endif
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the AWSOptions object to the dependency injection framework providing information
        /// that will be used to construct Amazon service clients.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="options">The default AWS options used to construct AWS service clients with.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection AddDefaultAWSOptions(this IServiceCollection collection, AWSOptions options)
        {
            return collection.AddDefaultAWSOptions(_ => options);
        }

        /// <summary>
        /// Adds the AWSOptions object to the dependency injection framework providing information
        /// that will be used to construct Amazon service clients.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="implementationFactory">The factory that creates the default AWS options.
        /// The AWS options will be used to construct AWS service clients
        /// </param>
        /// <param name="lifetime">The lifetime of the AWSOptions. The default is Singleton.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection AddDefaultAWSOptions(
            this IServiceCollection collection, 
            Func<IServiceProvider, AWSOptions> implementationFactory, 
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            collection.Add(new ServiceDescriptor(typeof(AWSOptions), implementationFactory, lifetime));
            return collection;
        }

        /// <summary>
        /// Adds the DefaultAWSCredentialsFactory object to the dependency injection framework
        /// This factory will be used to create the credentials for the Amazon service clients.
        /// </summary>
        public static IServiceCollection AddCredentialsFactory(this IServiceCollection collection)
        {
            return collection.AddCredentialsFactoryInternal();
        }

        /// <summary>
        /// Adds the DefaultAWSCredentialsFactory object to the dependency injection framework
        /// if no IAWSCredentialsFactory is already registered.
        /// This factory will be used to create the credentials for the Amazon service clients.
        /// </summary>
        public static IServiceCollection TryAddCredentialsFactory(this IServiceCollection collection)
        {
            return collection.AddCredentialsFactoryInternal(tryAdd: true);
        }

        /// <summary>
        /// Adds a IAWSCredentialsFactory object obtained via th provided awsCredentialsFactoryFunc to the dependency
        /// injection framework. This factory will be used to create the credentials for the Amazon service clients.
        /// </summary>
        public static IServiceCollection AddCredentialsFactory(
            this IServiceCollection collection,
            Func<IServiceProvider, IAWSCredentialsFactory> awsCredentialsFactoryFunc,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            return collection.AddCredentialsFactoryInternal(awsCredentialsFactoryFunc, lifetime, tryAdd: false);
        }

        /// <summary>
        /// Adds a IAWSCredentialsFactory object obtained via th provided awsCredentialsFactoryFunc to the dependency
        /// injection framework if no IAWSCredentialsFactory is already registered.
        /// This factory will be used to create the credentials for the Amazon service clients.
        /// </summary>
        public static IServiceCollection TryAddCredentialsFactory(
            this IServiceCollection collection,
            Func<IServiceProvider, IAWSCredentialsFactory> awsCredentialsFactoryFunc,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            return collection.AddCredentialsFactoryInternal(awsCredentialsFactoryFunc, lifetime, tryAdd: true);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework. The Amazon service client is not
        /// created until it is requested. If the ServiceLifetime property is set to Singleton, the default, then the same
        /// instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection AddAWSService<T>(this IServiceCollection collection, ServiceLifetime lifetime = ServiceLifetime.Singleton) where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(lifetime: lifetime);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework. The Amazon service client is not
        /// created until it is requested. If the ServiceLifetime property is set to Singleton, the default, then the same
        /// instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="options">The AWS options used to create the service client overriding the default AWS options added using AddDefaultAWSOptions.</param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <param name="credentialsFactoryFunc">
        /// A func which takes an IServiceProvider and the AWSOptions provided to this call and returns an IAWSCredentialsFactory used to create the service client.
        /// Must be provided if options are provided to this call _and_ a custom IAWSCredentialsFactory is registered via [Try]AddCredentialsFactory; otherwise the
        /// default will be used.
        /// </param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection AddAWSService<T>(this IServiceCollection collection, AWSOptions options, ServiceLifetime lifetime = ServiceLifetime.Singleton, Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null) where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(_ => options, credentialsFactoryFunc: credentialsFactoryFunc, lifetime: lifetime);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework. The Amazon service client is not
        /// created until it is requested. If the ServiceLifetime property is set to Singleton, the default, then the same
        /// instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="optionsFunc">A func which returns the AWS options used to create the service client overriding the default AWS options added using AddDefaultAWSOptions.</param>
        /// <param name="credentialsFactoryFunc">
        /// A func which takes an IServiceProvider and the AWSOptions resolved by optionsFunc and returns an IAWSCredentialsFactory used to create the service client.
        /// Must be provided if options are provided to this call _and_ a custom IAWSCredentialsFactory is registered via [Try]AddCredentialsFactory; otherwise the
        /// default will be used.
        /// </param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection AddAWSService<T>(
            this IServiceCollection collection,
            Func<IServiceProvider, AWSOptions> optionsFunc,
            Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(optionsFunc, credentialsFactoryFunc, lifetime);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework if the service type hasn't already been registered.
        /// The Amazon service client is not created until it is requested. If the ServiceLifetime property is set to Singleton,
        /// the default, then the same instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection TryAddAWSService<T>(this IServiceCollection collection, ServiceLifetime lifetime = ServiceLifetime.Singleton) where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(lifetime: lifetime, tryAdd: true);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework if the service type hasn't already been registered.
        /// The Amazon service client is not created until it is requested. If the ServiceLifetime property is set to Singleton,
        /// the default, then the same instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="options">The AWS options used to create the service client overriding the default AWS options added using AddDefaultAWSOptions.</param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <param name="credentialsFactoryFunc">
        /// A func which takes an IServiceProvider and the AWSOptions resolved by optionsFunc and returns an IAWSCredentialsFactory used to create the service client.
        /// Must be provided if options are provided to this call _and_ a custom IAWSCredentialsFactory is registered via [Try]AddCredentialsFactory; otherwise the
        /// default will be used.
        /// </param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection TryAddAWSService<T>(this IServiceCollection collection, AWSOptions options, ServiceLifetime lifetime = ServiceLifetime.Singleton, Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null) where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(_ => options, lifetime: lifetime, credentialsFactoryFunc: credentialsFactoryFunc, tryAdd: true);
        }

        /// <summary>
        /// Adds the Amazon service client to the dependency injection framework if the service type hasn't already been registered.
        /// The Amazon service client is not created until it is requested. If the ServiceLifetime property is set to Singleton,
        /// the default, then the same instance will be reused for the lifetime of the process and the object should not be disposed.
        /// </summary>
        /// <typeparam name="T">The AWS service interface, like IAmazonS3.</typeparam>
        /// <param name="collection"></param>
        /// <param name="optionsFunc">A func which returns the AWS options used to create the service client overriding the default AWS options added using AddDefaultAWSOptions.</param>
        /// <param name="credentialsFactoryFunc">
        /// A func which takes an IServiceProvider and the AWSOptions resolved by optionsFunc and returns an IAWSCredentialsFactory used to create the service client.
        /// Must be provided if options are provided to this call _and_ a custom IAWSCredentialsFactory is registered via [Try]AddCredentialsFactory; otherwise the
        /// default will be used.
        /// </param>
        /// <param name="lifetime">The lifetime of the service client created. The default is Singleton.</param>
        /// <returns>Returns back the IServiceCollection to continue the fluent system of IServiceCollection.</returns>
        public static IServiceCollection TryAddAWSService<T>(
            this IServiceCollection collection,
            Func<IServiceProvider, AWSOptions> optionsFunc,
            Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where T : IAmazonService
        {
            return collection.AddAWSServiceInternal<T>(optionsFunc, credentialsFactoryFunc, lifetime, tryAdd: true);
        }

        private static IServiceCollection AddCredentialsFactoryInternal(
            this IServiceCollection collection,
            Func<IServiceProvider, IAWSCredentialsFactory> awsCredentialsFactoryFunc = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton,
            bool tryAdd = false)
        {
            if (awsCredentialsFactoryFunc != null)
            {
                collection.SetCustomCredentialsFactoryRegistered();
            }

            awsCredentialsFactoryFunc = awsCredentialsFactoryFunc ?? (sp => sp.CreateDefaultCredentialsFactory(sp.GetService<AWSOptions>()));

            var serviceDescriptor = new ServiceDescriptor(typeof(IAWSCredentialsFactory), awsCredentialsFactoryFunc, lifetime);

            if (tryAdd)
            {
                collection.TryAdd(serviceDescriptor);
            }
            else
            {
                collection.Add(serviceDescriptor);
            }

            collection.TryAddTransient<AWSCredentials>(sp => sp.GetRequiredService<IAWSCredentialsFactory>().Create());

            return collection;
        }

        private static IServiceCollection AddAWSServiceInternal<T>(
            this IServiceCollection collection,
            Func<IServiceProvider, AWSOptions> optionsFunc = null,
            Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton,
            bool tryAdd = false)
            where T : IAmazonService
        {
            var descriptor = new ServiceDescriptor(
                typeof(T),
                sp => CreateServiceClient<T>(sp, optionsFunc, credentialsFactoryFunc),
                lifetime);

            if (tryAdd)
            {
                collection.TryAdd(descriptor);
            }
            else
            {
                collection.Add(descriptor);
            }

            return collection;
        }

        private static object CreateServiceClient<T>(
            IServiceProvider sp,
            Func<IServiceProvider, AWSOptions> optionsFunc = null,
            Func<IServiceProvider, AWSOptions, IAWSCredentialsFactory> credentialsFactoryFunc = null)
        {
            var options = optionsFunc?.Invoke(sp)
                          ?? sp.GetService<AWSOptions>()
                          ?? sp.GetService<IConfiguration>()?.GetAWSOptions();

            if (optionsFunc != null &&
                credentialsFactoryFunc == null &&
                sp.CustomCredentialsFactoryRegistered() && // If we're using the default credentials factory, no harm done since we're creating one with the provided AWSOptions below.
                options?.Equals(sp.GetService<AWSOptions>()) != true)
            {
                throw new ArgumentNullException(
                    nameof(credentialsFactoryFunc),
                    "A credentialsFactoryFunc must be provided when options(Func) is provided and [Try]AddCredentialsFactory is called with a custom IAWSCredentialsFactory. " +
                    "Not doing this would result in the ServiceClient using a different AWSOptions object than the IAWSCredentialsFactory");
            }

            var awsCredentialsFactory = credentialsFactoryFunc?.Invoke(sp, options)
                                        ?? sp.GetService<IAWSCredentialsFactory>()
                                        ?? sp.CreateDefaultCredentialsFactory(options);

            var clientFactory = new ClientFactory(
                typeof(T),
                options,
                awsCredentialsFactory,
                sp.GetService<ILoggerFactory>(),
                sp.GetService<IConfiguration>());

            return clientFactory.CreateServiceClient();
        }

        private static IAWSCredentialsFactory CreateDefaultCredentialsFactory(this IServiceProvider sp, AWSOptions options) =>
            new DefaultAWSCredentialsFactory(options, sp.GetService<ILoggerFactory>()?.CreateLogger<DefaultAWSCredentialsFactory>());

        private static bool CustomCredentialsFactoryRegistered(this IServiceProvider sp) => sp.GetService<CustomCredentialsFactoryRegisteredType>() != null;

        private static void SetCustomCredentialsFactoryRegistered(this IServiceCollection collection) => collection.AddSingleton<CustomCredentialsFactoryRegisteredType>();

        private class CustomCredentialsFactoryRegisteredType { }
    }
}
