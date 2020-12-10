#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Paginators for the NetworkManager service
    ///</summary>
    public class NetworkManagerPaginatorFactory : INetworkManagerPaginatorFactory
    {
        private readonly IAmazonNetworkManager client;

        internal NetworkManagerPaginatorFactory(IAmazonNetworkManager client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeGlobalNetworks operation
        ///</summary>
        public IDescribeGlobalNetworksPaginator DescribeGlobalNetworks(DescribeGlobalNetworksRequest request) 
        {
            return new DescribeGlobalNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetConnections operation
        ///</summary>
        public IGetConnectionsPaginator GetConnections(GetConnectionsRequest request) 
        {
            return new GetConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCustomerGatewayAssociations operation
        ///</summary>
        public IGetCustomerGatewayAssociationsPaginator GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request) 
        {
            return new GetCustomerGatewayAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDevices operation
        ///</summary>
        public IGetDevicesPaginator GetDevices(GetDevicesRequest request) 
        {
            return new GetDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLinkAssociations operation
        ///</summary>
        public IGetLinkAssociationsPaginator GetLinkAssociations(GetLinkAssociationsRequest request) 
        {
            return new GetLinkAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLinks operation
        ///</summary>
        public IGetLinksPaginator GetLinks(GetLinksRequest request) 
        {
            return new GetLinksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSites operation
        ///</summary>
        public IGetSitesPaginator GetSites(GetSitesRequest request) 
        {
            return new GetSitesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayConnectPeerAssociations operation
        ///</summary>
        public IGetTransitGatewayConnectPeerAssociationsPaginator GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request) 
        {
            return new GetTransitGatewayConnectPeerAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayRegistrations operation
        ///</summary>
        public IGetTransitGatewayRegistrationsPaginator GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request) 
        {
            return new GetTransitGatewayRegistrationsPaginator(this.client, request);
        }
    }
}
#endif