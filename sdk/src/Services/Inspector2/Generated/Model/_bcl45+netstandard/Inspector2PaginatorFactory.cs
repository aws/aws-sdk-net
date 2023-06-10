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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Paginators for the Inspector2 service
    ///</summary>
    public class Inspector2PaginatorFactory : IInspector2PaginatorFactory
    {
        private readonly IAmazonInspector2 client;

        internal Inspector2PaginatorFactory(IAmazonInspector2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountPermissions operation
        ///</summary>
        public IListAccountPermissionsPaginator ListAccountPermissions(ListAccountPermissionsRequest request) 
        {
            return new ListAccountPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoverage operation
        ///</summary>
        public IListCoveragePaginator ListCoverage(ListCoverageRequest request) 
        {
            return new ListCoveragePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoverageStatistics operation
        ///</summary>
        public IListCoverageStatisticsPaginator ListCoverageStatistics(ListCoverageStatisticsRequest request) 
        {
            return new ListCoverageStatisticsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDelegatedAdminAccounts operation
        ///</summary>
        public IListDelegatedAdminAccountsPaginator ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request) 
        {
            return new ListDelegatedAdminAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFilters operation
        ///</summary>
        public IListFiltersPaginator ListFilters(ListFiltersRequest request) 
        {
            return new ListFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindingAggregations operation
        ///</summary>
        public IListFindingAggregationsPaginator ListFindingAggregations(ListFindingAggregationsRequest request) 
        {
            return new ListFindingAggregationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFindings operation
        ///</summary>
        public IListFindingsPaginator ListFindings(ListFindingsRequest request) 
        {
            return new ListFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsageTotals operation
        ///</summary>
        public IListUsageTotalsPaginator ListUsageTotals(ListUsageTotalsRequest request) 
        {
            return new ListUsageTotalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchVulnerabilities operation
        ///</summary>
        public ISearchVulnerabilitiesPaginator SearchVulnerabilities(SearchVulnerabilitiesRequest request) 
        {
            return new SearchVulnerabilitiesPaginator(this.client, request);
        }
    }
}