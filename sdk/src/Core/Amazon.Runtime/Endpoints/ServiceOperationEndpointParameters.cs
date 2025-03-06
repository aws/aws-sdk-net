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
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// A Container class for parameters used for service operations endpoint resolution.
    /// </summary>
    public class ServiceOperationEndpointParameters
    {
        public ServiceOperationEndpointParameters(AmazonWebServiceRequest request)
        {
            Request = request;
        }

        public ServiceOperationEndpointParameters(AmazonWebServiceRequest request, RegionEndpoint alternateEndpoint)
            : this(request)
        {
            AlternateEndpoint = alternateEndpoint;
        }

        /// <summary>
        /// Request for the desired service operation.
        /// </summary>
        public AmazonWebServiceRequest Request { get; }

        /// <summary>
        /// Alternate endpoint that overrides the endpoint configured for service client.
        /// </summary>
        public RegionEndpoint AlternateEndpoint { get; }
    }
}
