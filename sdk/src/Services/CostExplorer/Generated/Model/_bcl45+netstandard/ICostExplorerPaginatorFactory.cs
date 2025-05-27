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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Paginators for the CostExplorer service
    ///</summary>
    public interface ICostExplorerPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetAnomalies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetAnomaliesPaginator GetAnomalies(GetAnomaliesRequest request);

        /// <summary>
        /// Paginator for GetAnomalyMonitors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetAnomalyMonitorsPaginator GetAnomalyMonitors(GetAnomalyMonitorsRequest request);

        /// <summary>
        /// Paginator for GetAnomalySubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetAnomalySubscriptionsPaginator GetAnomalySubscriptions(GetAnomalySubscriptionsRequest request);

        /// <summary>
        /// Paginator for GetCostAndUsageComparisons operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetCostAndUsageComparisonsPaginator GetCostAndUsageComparisons(GetCostAndUsageComparisonsRequest request);

        /// <summary>
        /// Paginator for GetCostComparisonDrivers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetCostComparisonDriversPaginator GetCostComparisonDrivers(GetCostComparisonDriversRequest request);

        /// <summary>
        /// Paginator for GetSavingsPlansCoverage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSavingsPlansCoveragePaginator GetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request);

        /// <summary>
        /// Paginator for GetSavingsPlansUtilizationDetails operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSavingsPlansUtilizationDetailsPaginator GetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request);

        /// <summary>
        /// Paginator for ListCostAllocationTagBackfillHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCostAllocationTagBackfillHistoryPaginator ListCostAllocationTagBackfillHistory(ListCostAllocationTagBackfillHistoryRequest request);

        /// <summary>
        /// Paginator for ListCostAllocationTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCostAllocationTagsPaginator ListCostAllocationTags(ListCostAllocationTagsRequest request);

        /// <summary>
        /// Paginator for ListCostCategoryDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCostCategoryDefinitionsPaginator ListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request);
    }
}