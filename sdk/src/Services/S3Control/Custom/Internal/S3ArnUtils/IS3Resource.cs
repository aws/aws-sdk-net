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
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Interface to cover various types of S3 resources
    /// </summary>
    public interface IS3Resource
    {
        /// <summary>
        /// Type of the S3 Resource. 
        /// </summary>
        S3ResourceType Type { get; set; }

        /// <summary>
        /// Name of the access point or bucket
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Key for object in bucket
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// The S3 resource full ARN representation
        /// </summary>
        string FullResourceName { get; }

        /// <summary>
        /// Validate if the ARN is compatible with
        /// options set in the client config
        /// </summary>
        /// <param name="config">A client config to validate with</param>
        /// <param name="region">The region to use for cross region checks</param>
        void ValidateArnWithClientConfig(IClientConfig config, RegionEndpoint region);

        /// <summary>
        /// Get the endpoint based on the client config options
        /// </summary>
        /// <param name="config">A client config to provide necessary values for the endpoint</param>
        /// <returns></returns>
        Uri GetEndpoint(IClientConfig config);
    }
}
