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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Paginators for the Private5G service
    ///</summary>
    public class Private5GPaginatorFactory : IPrivate5GPaginatorFactory
    {
        private readonly IAmazonPrivate5G client;

        internal Private5GPaginatorFactory(IAmazonPrivate5G client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDeviceIdentifiers operation
        ///</summary>
        public IListDeviceIdentifiersPaginator ListDeviceIdentifiers(ListDeviceIdentifiersRequest request) 
        {
            return new ListDeviceIdentifiersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworkResources operation
        ///</summary>
        public IListNetworkResourcesPaginator ListNetworkResources(ListNetworkResourcesRequest request) 
        {
            return new ListNetworkResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        public IListNetworksPaginator ListNetworks(ListNetworksRequest request) 
        {
            return new ListNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworkSites operation
        ///</summary>
        public IListNetworkSitesPaginator ListNetworkSites(ListNetworkSitesRequest request) 
        {
            return new ListNetworkSitesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrders operation
        ///</summary>
        public IListOrdersPaginator ListOrders(ListOrdersRequest request) 
        {
            return new ListOrdersPaginator(this.client, request);
        }
    }
}