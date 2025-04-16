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
using Amazon.Runtime.Internal;

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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAddonVersionsPaginator DescribeAddonVersions(DescribeAddonVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Paginator for ListAccessEntries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessEntriesPaginator ListAccessEntries(ListAccessEntriesRequest request);

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAddons operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAddonsPaginator ListAddons(ListAddonsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAccessPolicies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociatedAccessPoliciesPaginator ListAssociatedAccessPolicies(ListAssociatedAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListEksAnywhereSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEksAnywhereSubscriptionsPaginator ListEksAnywhereSubscriptions(ListEksAnywhereSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListFargateProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFargateProfilesPaginator ListFargateProfiles(ListFargateProfilesRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviderConfigs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdentityProviderConfigsPaginator ListIdentityProviderConfigs(ListIdentityProviderConfigsRequest request);

        /// <summary>
        /// Paginator for ListInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInsightsPaginator ListInsights(ListInsightsRequest request);

        /// <summary>
        /// Paginator for ListNodegroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodegroupsPaginator ListNodegroups(ListNodegroupsRequest request);

        /// <summary>
        /// Paginator for ListPodIdentityAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPodIdentityAssociationsPaginator ListPodIdentityAssociations(ListPodIdentityAssociationsRequest request);

        /// <summary>
        /// Paginator for ListUpdates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUpdatesPaginator ListUpdates(ListUpdatesRequest request);
    }
}