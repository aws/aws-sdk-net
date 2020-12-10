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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Paginators for the NetworkManager service
    ///</summary>
    public interface INetworkManagerPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeGlobalNetworks operation
        ///</summary>
        IDescribeGlobalNetworksPaginator DescribeGlobalNetworks(DescribeGlobalNetworksRequest request);

        /// <summary>
        /// Paginator for GetConnections operation
        ///</summary>
        IGetConnectionsPaginator GetConnections(GetConnectionsRequest request);

        /// <summary>
        /// Paginator for GetCustomerGatewayAssociations operation
        ///</summary>
        IGetCustomerGatewayAssociationsPaginator GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request);

        /// <summary>
        /// Paginator for GetDevices operation
        ///</summary>
        IGetDevicesPaginator GetDevices(GetDevicesRequest request);

        /// <summary>
        /// Paginator for GetLinkAssociations operation
        ///</summary>
        IGetLinkAssociationsPaginator GetLinkAssociations(GetLinkAssociationsRequest request);

        /// <summary>
        /// Paginator for GetLinks operation
        ///</summary>
        IGetLinksPaginator GetLinks(GetLinksRequest request);

        /// <summary>
        /// Paginator for GetSites operation
        ///</summary>
        IGetSitesPaginator GetSites(GetSitesRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayConnectPeerAssociations operation
        ///</summary>
        IGetTransitGatewayConnectPeerAssociationsPaginator GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRegistrations operation
        ///</summary>
        IGetTransitGatewayRegistrationsPaginator GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request);
    }
}
#endif