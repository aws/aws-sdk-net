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

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Paginators for the EKS service
    ///</summary>
    public interface IEKSPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAddonVersions operation
        ///</summary>
        IDescribeAddonVersionsPaginator DescribeAddonVersions(DescribeAddonVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Paginator for ListAccessEntries operation
        ///</summary>
        IListAccessEntriesPaginator ListAccessEntries(ListAccessEntriesRequest request);

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAddons operation
        ///</summary>
        IListAddonsPaginator ListAddons(ListAddonsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAccessPolicies operation
        ///</summary>
        IListAssociatedAccessPoliciesPaginator ListAssociatedAccessPolicies(ListAssociatedAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListEksAnywhereSubscriptions operation
        ///</summary>
        IListEksAnywhereSubscriptionsPaginator ListEksAnywhereSubscriptions(ListEksAnywhereSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListFargateProfiles operation
        ///</summary>
        IListFargateProfilesPaginator ListFargateProfiles(ListFargateProfilesRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviderConfigs operation
        ///</summary>
        IListIdentityProviderConfigsPaginator ListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request);

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        IListInsightsPaginator ListInsights(ListInsightsRequest request);

        /// <summary>
        /// Paginator for ListNodegroups operation
        ///</summary>
        IListNodegroupsPaginator ListNodegroups(ListNodegroupsRequest request);

        /// <summary>
        /// Paginator for ListPodIdentityAssociations operation
        ///</summary>
        IListPodIdentityAssociationsPaginator ListPodIdentityAssociations(ListPodIdentityAssociationsRequest request);

        /// <summary>
        /// Paginator for ListUpdates operation
        ///</summary>
        IListUpdatesPaginator ListUpdates(ListUpdatesRequest request);
    }
}