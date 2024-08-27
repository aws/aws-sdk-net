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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */

using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.MediaPackageV2.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving MediaPackageV2 endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal MediaPackageV2EndpointProvider and MediaPackageV2EndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class MediaPackageV2EndpointParameters : EndpointParameters
    {
        /// <summary>
        /// MediaPackageV2EndpointParameters constructor
        /// </summary>
        public MediaPackageV2EndpointParameters()
        {
            UseDualStack = false;
            UseFIPS = false;
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
        /// UseDualStack parameter
        /// </summary>
        public bool? UseDualStack 
        { 
            get { return (bool?)this["UseDualStack"]; }
            set { this["UseDualStack"] = value; } 
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
        /// Endpoint parameter
        /// </summary>
        public string Endpoint 
        { 
            get { return (string)this["Endpoint"]; }
            set { this["Endpoint"] = value; } 
        }
    }
}