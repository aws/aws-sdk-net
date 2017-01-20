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

using Amazon;
using Amazon.Runtime;

using Amazon.Extensions.NETCore.Setup;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// The options used to construct AWS service clients like the Amazon.S3.AmazonS3Client.
    /// </summary>
    public class AWSOptions
    {
        /// <summary>
        /// The profile used to fetch AWS credentials for from the profile manager.
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// The location of the registered profiles. Set if using the non standard locations for profile stores.
        /// This is mostly used when running the application outside of an EC2 instance where the preferred 
        /// IAM credentials are used and also not running under a logged on user.
        /// </summary>
        public string ProfilesLocation { get; set; }

        /// <summary>
        /// The AWS region the service client should use when making service operations.
        /// </summary>
        public RegionEndpoint Region { get; set; }


        private ClientConfig _defaultClientConfig;

        /// <summary>
        /// A default ClientConfig object. When service client is created any values set on the default ClientConfig
        /// are copied to the service specific client config.
        /// </summary>
        public ClientConfig DefaultClientConfig
        {
            get
            {
                if (this._defaultClientConfig == null)
                    this._defaultClientConfig = new DefaultClientConfig();

                return this._defaultClientConfig;
            }
        }

        internal bool IsDefaultClientConfigSet
        {
            get
            {
                return this._defaultClientConfig != null;
            }
        }

        /// <summary>
        /// Create a service client for the specified service interface using the options set in this instance.
        /// For example if T is set to IAmazonS3 then the AmazonS3ServiceClient which implements IAmazonS3 is created
        /// and returned.
        /// </summary>
        /// <typeparam name="T">The service interface that a service client will be created for.</typeparam>
        /// <returns>The service client that implements the service interface.</returns>
        public T CreateServiceClient<T>() where T : IAmazonService
        {
            return (T)ClientFactory.CreateServiceClient(typeof(T), this);
        }
    }
}
