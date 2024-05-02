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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Paginators for the MediaConnect service
    ///</summary>
    public class MediaConnectPaginatorFactory : IMediaConnectPaginatorFactory
    {
        private readonly IAmazonMediaConnect client;

        internal MediaConnectPaginatorFactory(IAmazonMediaConnect client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBridges operation
        ///</summary>
        public IListBridgesPaginator ListBridges(ListBridgesRequest request) 
        {
            return new ListBridgesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntitlements operation
        ///</summary>
        public IListEntitlementsPaginator ListEntitlements(ListEntitlementsRequest request) 
        {
            return new ListEntitlementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        public IListFlowsPaginator ListFlows(ListFlowsRequest request) 
        {
            return new ListFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGatewayInstances operation
        ///</summary>
        public IListGatewayInstancesPaginator ListGatewayInstances(ListGatewayInstancesRequest request) 
        {
            return new ListGatewayInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        public IListOfferingsPaginator ListOfferings(ListOfferingsRequest request) 
        {
            return new ListOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReservations operation
        ///</summary>
        public IListReservationsPaginator ListReservations(ListReservationsRequest request) 
        {
            return new ListReservationsPaginator(this.client, request);
        }
    }
}