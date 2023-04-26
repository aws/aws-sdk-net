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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */

using Amazon.Runtime;
using Amazon.Runtime.Endpoints;

namespace Amazon.IVSRealTime.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving IVSRealTime endpoints
    /// Parameters can be sourced from client config and service operations
    /// Used by internal IVSRealTimeEndpointProvider and IVSRealTimeEndpointResolver
    /// Can be used by custom EndpointProvider, see ClientConfig.EndpointProvider
    /// </summary>
    public class IVSRealTimeEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// IVSRealTimeEndpointParameters constructor
        /// </summary>
        public IVSRealTimeEndpointParameters()
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