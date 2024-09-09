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
 * Do not modify this file. This file is generated from the ep2-parse-arn-2022-08-24.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.Ep2parsearn.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving Ep2parsearn endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal Ep2parsearnEndpointProvider and Ep2parsearnEndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class Ep2parsearnEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// Ep2parsearnEndpointParameters constructor
        /// </summary>
        public Ep2parsearnEndpointParameters()
        {
        }

        /// <summary>
        /// Region parameter
        /// </summary>
        public string Region 
        { 
            get { return (string)this["Region"]; }
            set { this["Region"] = value; } 
        }

        /// <summary>
        /// Bucket parameter
        /// </summary>
        public string Bucket 
        { 
            get { return (string)this["Bucket"]; }
            set { this["Bucket"] = value; } 
        }

        /// <summary>
        /// TestCaseId parameter
        /// </summary>
        public string TestCaseId 
        { 
            get { return (string)this["TestCaseId"]; }
            set { this["TestCaseId"] = value; } 
        }
    }
}