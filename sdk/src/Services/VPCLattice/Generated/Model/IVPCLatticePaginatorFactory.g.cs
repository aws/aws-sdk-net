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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Paginators for the VPCLattice service
    /// </summary>
    public interface IVPCLatticePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccessLogSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessLogSubscriptionsPaginator ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListDomainVerifications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainVerificationsPaginator ListDomainVerifications(ListDomainVerificationsRequest request);

        /// <summary>
        /// Paginator for ListListeners operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListListenersPaginator ListListeners(ListListenersRequest request);

        /// <summary>
        /// Paginator for ListResourceConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceConfigurationsPaginator ListResourceConfigurations(ListResourceConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListResourceEndpointAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceEndpointAssociationsPaginator ListResourceEndpointAssociations(ListResourceEndpointAssociationsRequest request);

        /// <summary>
        /// Paginator for ListResourceGateways operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceGatewaysPaginator ListResourceGateways(ListResourceGatewaysRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkResourceAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceNetworkResourceAssociationsPaginator ListServiceNetworkResourceAssociations(ListServiceNetworkResourceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkServiceAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceNetworkServiceAssociationsPaginator ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkVpcAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceNetworkVpcAssociationsPaginator ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkVpcEndpointAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceNetworkVpcEndpointAssociationsPaginator ListServiceNetworkVpcEndpointAssociations(ListServiceNetworkVpcEndpointAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceNetworksPaginator ListServiceNetworks(ListServiceNetworksRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListTargetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTargetGroupsPaginator ListTargetGroups(ListTargetGroupsRequest request);

        /// <summary>
        /// Paginator for ListTargets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTargetsPaginator ListTargets(ListTargetsRequest request);
    }
}
