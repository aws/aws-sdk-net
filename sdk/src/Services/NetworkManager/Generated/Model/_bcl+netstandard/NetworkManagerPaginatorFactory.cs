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

#pragma warning disable CS0612,CS0618
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
        /// Paginator for GetConnectPeerAssociations operation
        ///</summary>
        public IGetConnectPeerAssociationsPaginator GetConnectPeerAssociations(GetConnectPeerAssociationsRequest request) 
        {
            return new GetConnectPeerAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCoreNetworkChangeEvents operation
        ///</summary>
        public IGetCoreNetworkChangeEventsPaginator GetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request) 
        {
            return new GetCoreNetworkChangeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCoreNetworkChangeSet operation
        ///</summary>
        public IGetCoreNetworkChangeSetPaginator GetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request) 
        {
            return new GetCoreNetworkChangeSetPaginator(this.client, request);
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
        /// Paginator for GetNetworkResourceCounts operation
        ///</summary>
        public IGetNetworkResourceCountsPaginator GetNetworkResourceCounts(GetNetworkResourceCountsRequest request) 
        {
            return new GetNetworkResourceCountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetNetworkResourceRelationships operation
        ///</summary>
        public IGetNetworkResourceRelationshipsPaginator GetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request) 
        {
            return new GetNetworkResourceRelationshipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetNetworkResources operation
        ///</summary>
        public IGetNetworkResourcesPaginator GetNetworkResources(GetNetworkResourcesRequest request) 
        {
            return new GetNetworkResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetNetworkTelemetry operation
        ///</summary>
        public IGetNetworkTelemetryPaginator GetNetworkTelemetry(GetNetworkTelemetryRequest request) 
        {
            return new GetNetworkTelemetryPaginator(this.client, request);
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

        /// <summary>
        /// Paginator for ListAttachments operation
        ///</summary>
        public IListAttachmentsPaginator ListAttachments(ListAttachmentsRequest request) 
        {
            return new ListAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectPeers operation
        ///</summary>
        public IListConnectPeersPaginator ListConnectPeers(ListConnectPeersRequest request) 
        {
            return new ListConnectPeersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoreNetworkPolicyVersions operation
        ///</summary>
        public IListCoreNetworkPolicyVersionsPaginator ListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request) 
        {
            return new ListCoreNetworkPolicyVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoreNetworks operation
        ///</summary>
        public IListCoreNetworksPaginator ListCoreNetworks(ListCoreNetworksRequest request) 
        {
            return new ListCoreNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPeerings operation
        ///</summary>
        public IListPeeringsPaginator ListPeerings(ListPeeringsRequest request) 
        {
            return new ListPeeringsPaginator(this.client, request);
        }
    }
}