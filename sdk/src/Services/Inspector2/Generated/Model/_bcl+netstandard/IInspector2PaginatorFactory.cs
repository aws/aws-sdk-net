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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Paginators for the Inspector2 service
    ///</summary>
    public interface IInspector2PaginatorFactory
    {

        /// <summary>
        /// Paginator for GetCisScanResultDetails operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCisScanResultDetailsPaginator GetCisScanResultDetails(GetCisScanResultDetailsRequest request);

        /// <summary>
        /// Paginator for GetClustersForImage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetClustersForImagePaginator GetClustersForImage(GetClustersForImageRequest request);

        /// <summary>
        /// Paginator for ListAccountPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountPermissionsPaginator ListAccountPermissions(ListAccountPermissionsRequest request);

        /// <summary>
        /// Paginator for ListCisScanConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCisScanConfigurationsPaginator ListCisScanConfigurations(ListCisScanConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListCisScanResultsAggregatedByChecks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCisScanResultsAggregatedByChecksPaginator ListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request);

        /// <summary>
        /// Paginator for ListCisScanResultsAggregatedByTargetResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCisScanResultsAggregatedByTargetResourcePaginator ListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request);

        /// <summary>
        /// Paginator for ListCisScans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCisScansPaginator ListCisScans(ListCisScansRequest request);

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCoveragePaginator ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Paginator for ListCoverageStatistics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListCoverageStatisticsPaginator ListCoverageStatistics(ListCoverageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdminAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDelegatedAdminAccountsPaginator ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListFindingAggregations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFindingAggregationsPaginator ListFindingAggregations(ListFindingAggregationsRequest request);

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
        /// Paginator for ListMembers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListUsageTotals operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListUsageTotalsPaginator ListUsageTotals(ListUsageTotalsRequest request);

        /// <summary>
        /// Paginator for SearchVulnerabilities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        ISearchVulnerabilitiesPaginator SearchVulnerabilities(SearchVulnerabilitiesRequest request);
    }
}