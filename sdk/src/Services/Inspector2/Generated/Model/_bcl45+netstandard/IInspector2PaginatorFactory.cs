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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Paginators for the Inspector2 service
    ///</summary>
    public interface IInspector2PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccountPermissions operation
        ///</summary>
        IListAccountPermissionsPaginator ListAccountPermissions(ListAccountPermissionsRequest request);

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        IListCoveragePaginator ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Paginator for ListCoverageStatistics operation
        ///</summary>
        IListCoverageStatisticsPaginator ListCoverageStatistics(ListCoverageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdminAccounts operation
        ///</summary>
        IListDelegatedAdminAccountsPaginator ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListFindingAggregations operation
        ///</summary>
        IListFindingAggregationsPaginator ListFindingAggregations(ListFindingAggregationsRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListUsageTotals operation
        ///</summary>
        IListUsageTotalsPaginator ListUsageTotals(ListUsageTotalsRequest request);

        /// <summary>
        /// Paginator for SearchVulnerabilities operation
        ///</summary>
        ISearchVulnerabilitiesPaginator SearchVulnerabilities(SearchVulnerabilitiesRequest request);
    }
}