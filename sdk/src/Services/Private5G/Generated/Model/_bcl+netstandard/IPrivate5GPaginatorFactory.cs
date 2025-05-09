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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Paginators for the Private5G service
    ///</summary>
    public interface IPrivate5GPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDeviceIdentifiers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDeviceIdentifiersPaginator ListDeviceIdentifiers(ListDeviceIdentifiersRequest request);

        /// <summary>
        /// Paginator for ListNetworkResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkResourcesPaginator ListNetworkResources(ListNetworkResourcesRequest request);

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworksPaginator ListNetworks(ListNetworksRequest request);

        /// <summary>
        /// Paginator for ListNetworkSites operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkSitesPaginator ListNetworkSites(ListNetworkSitesRequest request);

        /// <summary>
        /// Paginator for ListOrders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrdersPaginator ListOrders(ListOrdersRequest request);
    }
}