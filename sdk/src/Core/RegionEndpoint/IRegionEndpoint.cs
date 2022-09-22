/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.Collections.Generic;

namespace Amazon.Internal
{
    public interface IRegionEndpoint
    {
        string RegionName { get;  }
        string DisplayName { get; }
        [Obsolete("Use GetEndpointForService(string serviceName, GetEndpointForServiceOptions options) instead", error: false)]
        Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack);
        /// <summary>
        /// Gets the endpoint for a service in a region.
        /// <para />
        /// For forwards compatibility, if the service being requested for isn't known in the region, this method 
        /// will generate an endpoint using the AWS endpoint heuristics. In this case, it is not guaranteed the
        /// endpoint will point to a valid service endpoint.
        /// </summary>
        /// <param name="serviceName">
        /// The services system name. Service system names can be obtained from the
        /// RegionEndpointServiceName member of the ClientConfig-derived class for the service.
        /// </param>
        /// <param name="options">
        /// Specify additional requirements on the <see cref="RegionEndpoint.Endpoint"/> to be returned.
        /// </param>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, GetEndpointForServiceOptions options);
    }

    [Obsolete("This interface is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
    public interface IRegionEndpointProvider
    {
        IEnumerable<IRegionEndpoint> AllRegionEndpoints { get; }

        IRegionEndpoint GetRegionEndpoint(string regionName);

        string GetDnsSuffixForPartition(string partition);
    }
}
