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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Paginators for the Macie2 service
    ///</summary>
    public interface IMacie2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBuckets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBucketsPaginator DescribeBuckets(DescribeBucketsRequest request);

        /// <summary>
        /// Paginator for GetUsageStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetUsageStatisticsPaginator GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListAllowLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAllowListsPaginator ListAllowLists(ListAllowListsRequest request);

        /// <summary>
        /// Paginator for ListAutomatedDiscoveryAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAutomatedDiscoveryAccountsPaginator ListAutomatedDiscoveryAccounts(ListAutomatedDiscoveryAccountsRequest request);

        /// <summary>
        /// Paginator for ListClassificationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListClassificationJobsPaginator ListClassificationJobs(ListClassificationJobsRequest request);

        /// <summary>
        /// Paginator for ListClassificationScopes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListClassificationScopesPaginator ListClassificationScopes(ListClassificationScopesRequest request);

        /// <summary>
        /// Paginator for ListCustomDataIdentifiers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomDataIdentifiersPaginator ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListFindingsFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingsFiltersPaginator ListFindingsFilters(ListFindingsFiltersRequest request);

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInvitationsPaginator ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Paginator for ListManagedDataIdentifiers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedDataIdentifiersPaginator ListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListResourceProfileArtifacts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceProfileArtifactsPaginator ListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request);

        /// <summary>
        /// Paginator for ListResourceProfileDetections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourceProfileDetectionsPaginator ListResourceProfileDetections(ListResourceProfileDetectionsRequest request);

        /// <summary>
        /// Paginator for ListSensitivityInspectionTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSensitivityInspectionTemplatesPaginator ListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchResourcesPaginator SearchResources(SearchResourcesRequest request);
    }
}