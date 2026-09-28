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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Paginators for the NetworkManager service
    /// </summary>
    public interface INetworkManagerPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeGlobalNetworks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeGlobalNetworksPaginator DescribeGlobalNetworks(DescribeGlobalNetworksRequest request);

        /// <summary>
        /// Paginator for GetConnectPeerAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetConnectPeerAssociationsPaginator GetConnectPeerAssociations(GetConnectPeerAssociationsRequest request);

        /// <summary>
        /// Paginator for GetConnections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetConnectionsPaginator GetConnections(GetConnectionsRequest request);

        /// <summary>
        /// Paginator for GetCoreNetworkChangeEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCoreNetworkChangeEventsPaginator GetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request);

        /// <summary>
        /// Paginator for GetCoreNetworkChangeSet operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCoreNetworkChangeSetPaginator GetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request);

        /// <summary>
        /// Paginator for GetCustomerGatewayAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCustomerGatewayAssociationsPaginator GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request);

        /// <summary>
        /// Paginator for GetDevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetDevicesPaginator GetDevices(GetDevicesRequest request);

        /// <summary>
        /// Paginator for GetLinkAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetLinkAssociationsPaginator GetLinkAssociations(GetLinkAssociationsRequest request);

        /// <summary>
        /// Paginator for GetLinks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetLinksPaginator GetLinks(GetLinksRequest request);

        /// <summary>
        /// Paginator for GetNetworkResourceCounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetNetworkResourceCountsPaginator GetNetworkResourceCounts(GetNetworkResourceCountsRequest request);

        /// <summary>
        /// Paginator for GetNetworkResourceRelationships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetNetworkResourceRelationshipsPaginator GetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request);

        /// <summary>
        /// Paginator for GetNetworkResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetNetworkResourcesPaginator GetNetworkResources(GetNetworkResourcesRequest request);

        /// <summary>
        /// Paginator for GetNetworkTelemetry operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetNetworkTelemetryPaginator GetNetworkTelemetry(GetNetworkTelemetryRequest request);

        /// <summary>
        /// Paginator for GetSites operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetSitesPaginator GetSites(GetSitesRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayConnectPeerAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTransitGatewayConnectPeerAssociationsPaginator GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRegistrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetTransitGatewayRegistrationsPaginator GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request);

        /// <summary>
        /// Paginator for ListAttachmentRoutingPolicyAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttachmentRoutingPolicyAssociationsPaginator ListAttachmentRoutingPolicyAssociations(ListAttachmentRoutingPolicyAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAttachments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttachmentsPaginator ListAttachments(ListAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListConnectPeers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectPeersPaginator ListConnectPeers(ListConnectPeersRequest request);

        /// <summary>
        /// Paginator for ListCoreNetworkPolicyVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCoreNetworkPolicyVersionsPaginator ListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request);

        /// <summary>
        /// Paginator for ListCoreNetworkPrefixListAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCoreNetworkPrefixListAssociationsPaginator ListCoreNetworkPrefixListAssociations(ListCoreNetworkPrefixListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCoreNetworkRoutingInformation operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCoreNetworkRoutingInformationPaginator ListCoreNetworkRoutingInformation(ListCoreNetworkRoutingInformationRequest request);

        /// <summary>
        /// Paginator for ListCoreNetworks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCoreNetworksPaginator ListCoreNetworks(ListCoreNetworksRequest request);

        /// <summary>
        /// Paginator for ListPeerings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPeeringsPaginator ListPeerings(ListPeeringsRequest request);
    }
}
