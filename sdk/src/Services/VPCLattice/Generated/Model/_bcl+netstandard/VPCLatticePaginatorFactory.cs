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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Paginators for the VPCLattice service
    ///</summary>
    public class VPCLatticePaginatorFactory : IVPCLatticePaginatorFactory
    {
        private readonly IAmazonVPCLattice client;

        internal VPCLatticePaginatorFactory(IAmazonVPCLattice client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessLogSubscriptions operation
        ///</summary>
        public IListAccessLogSubscriptionsPaginator ListAccessLogSubscriptions(ListAccessLogSubscriptionsRequest request) 
        {
            return new ListAccessLogSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListListeners operation
        ///</summary>
        public IListListenersPaginator ListListeners(ListListenersRequest request) 
        {
            return new ListListenersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        public IListRulesPaginator ListRules(ListRulesRequest request) 
        {
            return new ListRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceNetworks operation
        ///</summary>
        public IListServiceNetworksPaginator ListServiceNetworks(ListServiceNetworksRequest request) 
        {
            return new ListServiceNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceNetworkServiceAssociations operation
        ///</summary>
        public IListServiceNetworkServiceAssociationsPaginator ListServiceNetworkServiceAssociations(ListServiceNetworkServiceAssociationsRequest request) 
        {
            return new ListServiceNetworkServiceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceNetworkVpcAssociations operation
        ///</summary>
        public IListServiceNetworkVpcAssociationsPaginator ListServiceNetworkVpcAssociations(ListServiceNetworkVpcAssociationsRequest request) 
        {
            return new ListServiceNetworkVpcAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargetGroups operation
        ///</summary>
        public IListTargetGroupsPaginator ListTargetGroups(ListTargetGroupsRequest request) 
        {
            return new ListTargetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTargets operation
        ///</summary>
        public IListTargetsPaginator ListTargets(ListTargetsRequest request) 
        {
            return new ListTargetsPaginator(this.client, request);
        }
    }
}