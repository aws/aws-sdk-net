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
        IGetAnomaliesPaginator GetAnomalies(GetAnomaliesRequest request);

        /// <summary>
        /// Paginator for GetAnomalyMonitors operation
        ///</summary>
        IGetAnomalyMonitorsPaginator GetAnomalyMonitors(GetAnomalyMonitorsRequest request);

        /// <summary>
        /// Paginator for GetAnomalySubscriptions operation
        ///</summary>
        IGetAnomalySubscriptionsPaginator GetAnomalySubscriptions(GetAnomalySubscriptionsRequest request);

        /// <summary>
        /// Paginator for GetSavingsPlansCoverage operation
        ///</summary>
        IGetSavingsPlansCoveragePaginator GetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request);

        /// <summary>
        /// Paginator for GetSavingsPlansUtilizationDetails operation
        ///</summary>
        IGetSavingsPlansUtilizationDetailsPaginator GetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request);

        /// <summary>
        /// Paginator for ListCostAllocationTagBackfillHistory operation
        ///</summary>
        IListCostAllocationTagBackfillHistoryPaginator ListCostAllocationTagBackfillHistory(ListCostAllocationTagBackfillHistoryRequest request);

        /// <summary>
        /// Paginator for ListCostAllocationTags operation
        ///</summary>
        IListCostAllocationTagsPaginator ListCostAllocationTags(ListCostAllocationTagsRequest request);

        /// <summary>
        /// Paginator for ListCostCategoryDefinitions operation
        ///</summary>
        IListCostCategoryDefinitionsPaginator ListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request);
    }
}