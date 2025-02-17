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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Paginators for the EKS service
    ///</summary>
    public class EKSPaginatorFactory : IEKSPaginatorFactory
    {
        private readonly IAmazonEKS client;

        internal EKSPaginatorFactory(IAmazonEKS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAddonVersions operation
        ///</summary>
        public IDescribeAddonVersionsPaginator DescribeAddonVersions(DescribeAddonVersionsRequest request) 
        {
            return new DescribeAddonVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        public IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request) 
        {
            return new DescribeClusterVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessEntries operation
        ///</summary>
        public IListAccessEntriesPaginator ListAccessEntries(ListAccessEntriesRequest request) 
        {
            return new ListAccessEntriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        public IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request) 
        {
            return new ListAccessPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAddons operation
        ///</summary>
        public IListAddonsPaginator ListAddons(ListAddonsRequest request) 
        {
            return new ListAddonsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedAccessPolicies operation
        ///</summary>
        public IListAssociatedAccessPoliciesPaginator ListAssociatedAccessPolicies(ListAssociatedAccessPoliciesRequest request) 
        {
            return new ListAssociatedAccessPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEksAnywhereSubscriptions operation
        ///</summary>
        public IListEksAnywhereSubscriptionsPaginator ListEksAnywhereSubscriptions(ListEksAnywhereSubscriptionsRequest request) 
        {
            return new ListEksAnywhereSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFargateProfiles operation
        ///</summary>
        public IListFargateProfilesPaginator ListFargateProfiles(ListFargateProfilesRequest request) 
        {
            return new ListFargateProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdentityProviderConfigs operation
        ///</summary>
        public IListIdentityProviderConfigsPaginator ListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request) 
        {
            return new ListIdentityProviderConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        public IListInsightsPaginator ListInsights(ListInsightsRequest request) 
        {
            return new ListInsightsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodegroups operation
        ///</summary>
        public IListNodegroupsPaginator ListNodegroups(ListNodegroupsRequest request) 
        {
            return new ListNodegroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPodIdentityAssociations operation
        ///</summary>
        public IListPodIdentityAssociationsPaginator ListPodIdentityAssociations(ListPodIdentityAssociationsRequest request) 
        {
            return new ListPodIdentityAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUpdates operation
        ///</summary>
        public IListUpdatesPaginator ListUpdates(ListUpdatesRequest request) 
        {
            return new ListUpdatesPaginator(this.client, request);
        }
    }
}