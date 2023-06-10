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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Paginators for the VPCLattice service
    ///</summary>
    public interface IVPCLatticePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessLogSubscriptions operation
        ///</summary>
        IListAccessLogSubscriptionsPaginator ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListListeners operation
        ///</summary>
        IListListenersPaginator ListListeners(ListListenersRequest request);

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        IListRulesPaginator ListRules(ListRulesRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworks operation
        ///</summary>
        IListServiceNetworksPaginator ListServiceNetworks(ListServiceNetworksRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkServiceAssociations operation
        ///</summary>
        IListServiceNetworkServiceAssociationsPaginator ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServiceNetworkVpcAssociations operation
        ///</summary>
        IListServiceNetworkVpcAssociationsPaginator ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListTargetGroups operation
        ///</summary>
        IListTargetGroupsPaginator ListTargetGroups(ListTargetGroupsRequest request);

        /// <summary>
        /// Paginator for ListTargets operation
        ///</summary>
        IListTargetsPaginator ListTargets(ListTargetsRequest request);
    }
}