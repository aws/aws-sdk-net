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
     
        /// <summary>
        /// If set this role will be assumed using the resolved AWS credentials.
        /// </summary>
        public string SessionRoleArn { get; set; }

        /// <summary>
        /// The session name for the assumed session using the SessionRoleArn.
        /// </summary>
        public string SessionName { get; set; } = "DefaultSessionName";

        /// <summary>
        /// AWS Credentials used for creating service clients. If this is set it overrides the Profile property.
        /// </summary>
        public AWSCredentials Credentials { get; set; }

        /// <summary>
        /// The default configuration mode set for created service clients.
        /// </summary>
        public DefaultConfigurationMode? DefaultConfigurationMode { get; set; }

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

        /// <summary>
        /// Logging settings that should be applied to SDK global configuration. This setting is applied while creating
        /// the service client through this package.
        /// </summary>
        public LoggingSetting Logging { get; set; }

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
            return (T)ClientFactory.CreateServiceClient(null, typeof(T), this);
        }

        /// <summary>
        /// Container for logging settings of the SDK
        /// </summary>
        public class LoggingSetting
        {
            /// <summary>
            /// Logging destination.
            /// </summary>
            public LoggingOptions? LogTo { get; set; }

            /// <summary>
            /// When to log responses.
            /// </summary>
            public ResponseLoggingOption? LogResponses { get; set; }

            /// <summary>
            /// Gets or sets the size limit in bytes for logged responses. If logging for response
            ///     body is enabled, logged response body is limited to this size. The SDK defaults to 1KB if this property is net set.
            /// </summary>
            public int? LogResponsesSizeLimit { get; set; }

            /// <summary>
            /// Whether or not to log SDK metrics.
            /// </summary>
            public bool? LogMetrics { get; set; }

        }
    }
}
