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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.ECRPublic.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving ECRPublic endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal ECRPublicEndpointProvider and ECRPublicEndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class ECRPublicEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// ECRPublicEndpointParameters constructor
        /// </summary>
        public ECRPublicEndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
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
        /// UseFIPS parameter
        /// </summary>
        public bool? UseFIPS 
        { 
            get { return (bool?)this["UseFIPS"]; }
            set { this["UseFIPS"] = value; } 
        }

        /// <summary>
        /// UseDualStack parameter
        /// </summary>
        public bool? UseDualStack 
        { 
            get { return (bool?)this["UseDualStack"]; }
            set { this["UseDualStack"] = value; } 
        }
    }
}