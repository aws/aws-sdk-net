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

/*
 * Do not modify this file. This file is generated from the ep2-s3-host-label-2022-08-24.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.Ep2s3hostlabel.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving Ep2s3hostlabel endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal Ep2s3hostlabelEndpointProvider and Ep2s3hostlabelEndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class Ep2s3hostlabelEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// Ep2s3hostlabelEndpointParameters constructor
        /// </summary>
        public Ep2s3hostlabelEndpointParameters()
        {
        }

        /// <summary>
        /// BucketName parameter
        /// </summary>
        public string BucketName 
        { 
            get { return (string)this["BucketName"]; }
            set { this["BucketName"] = value; } 
        }
    }
}