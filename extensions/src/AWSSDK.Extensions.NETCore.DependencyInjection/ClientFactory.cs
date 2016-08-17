/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

using Amazon.Runtime;

namespace Amazon.Extensions.NETCore.DependencyInjection
{
    /// <summary>
    /// The factory class for creating AWS service clients from the AWS SDK for .NET.
    /// </summary>
    public class ClientFactory
    {
        private static readonly Type[] EMPTY_TYPES = new Type[0];
        private static readonly object[] EMPTY_PARAMETERS = new object[0];

        Type _type;

        /// <summary>
        /// Constructs an instance of the ClientFactory
        /// </summary>
        /// <param name="type">The type object for the Amazon service client interface, for example IAmazonS3.</param>
        public ClientFactory(Type type)
        {
            this._type = type;
        }

        /// <summary>
        /// Creates the AWS service client that implements the service client interface. The AWSOptions object
        /// will be searched for in the IServiceProvider.
        /// </summary>
        /// <param name="provider">The dependency injection provider.</param>
        /// <returns>The AWS service client</returns>
        public object CreateServiceFactory(IServiceProvider provider)
        {
            var options = provider.GetService<AWSOptions>();
            var credentials = CreateCredentials(options);
            var config = CreateConfig(options);
            var client = CreateClient(credentials, config);
            return client;
        }

        /// <summary>
        /// Creates the service client using the credentials and client config.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        private AmazonServiceClient CreateClient(AWSCredentials credentials, ClientConfig config)
        {
            var clientTypeName = _type.Namespace + "." + _type.Name.Substring(1) + "Client";
            var clientType = _type.GetTypeInfo().Assembly.GetType(clientTypeName);

            var constructor = clientType.GetConstructor(new Type[] { typeof(AWSCredentials), config.GetType() });
            var client = constructor.Invoke(new object[] { credentials, config }) as AmazonServiceClient;
            return client;
        }

        /// <summary>
        /// Creates the AWSCredentials using either the profile indicated from the AWSOptions object
        /// of the SDK fallback credentials search.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private AWSCredentials CreateCredentials(AWSOptions options)
        {
            if (options != null &&
                !string.IsNullOrEmpty(options.Profile) &&
                StoredProfileAWSCredentials.IsProfileKnown(options.Profile, options.ProfilesLocation))
            {
                return new StoredProfileAWSCredentials(options.Profile, options.ProfilesLocation);
            }

            return FallbackCredentialsFactory.GetCredentials();
        }

        /// <summary>
        /// Creates the ClientConfig object for the service client.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private ClientConfig CreateConfig(AWSOptions options)
        {
            var configTypeName = _type.Namespace + "." + _type.Name.Substring(1) + "Config";
            var configType = _type.GetTypeInfo().Assembly.GetType(configTypeName);

            var constructor = configType.GetConstructor(EMPTY_TYPES);
            ClientConfig config = constructor.Invoke(EMPTY_PARAMETERS) as ClientConfig;

            if (options != null)
            {
                config.RegionEndpoint = options.Region;
            }

            return config;
        }
    }

}
