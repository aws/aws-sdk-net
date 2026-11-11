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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Paginators for the Inspector2 service
    /// </summary>
    public interface IInspector2PaginatorFactory
    {
        /// <summary>
        /// Paginator for GetCisScanResultDetails operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCisScanResultDetailsPaginator GetCisScanResultDetails(GetCisScanResultDetailsRequest request);

        /// <summary>
        /// Paginator for GetClustersForImage operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetClustersForImagePaginator GetClustersForImage(GetClustersForImageRequest request);

        /// <summary>
        /// Paginator for ListAccountPermissions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountPermissionsPaginator ListAccountPermissions(ListAccountPermissionsRequest request);

        /// <summary>
        /// Paginator for ListCisScanConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCisScanConfigurationsPaginator ListCisScanConfigurations(ListCisScanConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListCisScanResultsAggregatedByChecks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCisScanResultsAggregatedByChecksPaginator ListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request);

        /// <summary>
        /// Paginator for ListCisScanResultsAggregatedByTargetResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCisScanResultsAggregatedByTargetResourcePaginator ListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request);

        /// <summary>
        /// Paginator for ListCisScans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCisScansPaginator ListCisScans(ListCisScansRequest request);

        /// <summary>
        /// Paginator for ListConnectorScanConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectorScanConfigurationsPaginator ListConnectorScanConfigurations(ListConnectorScanConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListCoverage operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCoveragePaginator ListCoverage(ListCoverageRequest request);

        /// <summary>
        /// Paginator for ListCoverageStatistics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListCoverageStatisticsPaginator ListCoverageStatistics(ListCoverageStatisticsRequest request);

        /// <summary>
        /// Paginator for ListDelegatedAdminAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDelegatedAdminAccountsPaginator ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request);

        /// <summary>
        /// Paginator for ListFilters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFiltersPaginator ListFilters(ListFiltersRequest request);

        /// <summary>
        /// Paginator for ListFindingAggregations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFindingAggregationsPaginator ListFindingAggregations(ListFindingAggregationsRequest request);

        /// <summary>
        /// Paginator for ListFindings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFindingsPaginator ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListOnDemandScans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOnDemandScansPaginator ListOnDemandScans(ListOnDemandScansRequest request);

        /// <summary>
        /// Paginator for ListUsageTotals operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsageTotalsPaginator ListUsageTotals(ListUsageTotalsRequest request);

        /// <summary>
        /// Paginator for SearchVulnerabilities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        ISearchVulnerabilitiesPaginator SearchVulnerabilities(SearchVulnerabilitiesRequest request);
    }
}
