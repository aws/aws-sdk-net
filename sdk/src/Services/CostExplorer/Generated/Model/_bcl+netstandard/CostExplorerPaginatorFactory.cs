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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Paginators for the CostExplorer service
    ///</summary>
    public class CostExplorerPaginatorFactory : ICostExplorerPaginatorFactory
    {
        private readonly IAmazonCostExplorer client;

        internal CostExplorerPaginatorFactory(IAmazonCostExplorer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetAnomalies operation
        ///</summary>
        public IGetAnomaliesPaginator GetAnomalies(GetAnomaliesRequest request) 
        {
            return new GetAnomaliesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAnomalyMonitors operation
        ///</summary>
        public IGetAnomalyMonitorsPaginator GetAnomalyMonitors(GetAnomalyMonitorsRequest request) 
        {
            return new GetAnomalyMonitorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAnomalySubscriptions operation
        ///</summary>
        public IGetAnomalySubscriptionsPaginator GetAnomalySubscriptions(GetAnomalySubscriptionsRequest request) 
        {
            return new GetAnomalySubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCostAndUsageComparisons operation
        ///</summary>
        public IGetCostAndUsageComparisonsPaginator GetCostAndUsageComparisons(GetCostAndUsageComparisonsRequest request) 
        {
            return new GetCostAndUsageComparisonsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCostComparisonDrivers operation
        ///</summary>
        public IGetCostComparisonDriversPaginator GetCostComparisonDrivers(GetCostComparisonDriversRequest request) 
        {
            return new GetCostComparisonDriversPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSavingsPlansCoverage operation
        ///</summary>
        public IGetSavingsPlansCoveragePaginator GetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request) 
        {
            return new GetSavingsPlansCoveragePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSavingsPlansUtilizationDetails operation
        ///</summary>
        public IGetSavingsPlansUtilizationDetailsPaginator GetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request) 
        {
            return new GetSavingsPlansUtilizationDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCostAllocationTagBackfillHistory operation
        ///</summary>
        public IListCostAllocationTagBackfillHistoryPaginator ListCostAllocationTagBackfillHistory(ListCostAllocationTagBackfillHistoryRequest request) 
        {
            return new ListCostAllocationTagBackfillHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCostAllocationTags operation
        ///</summary>
        public IListCostAllocationTagsPaginator ListCostAllocationTags(ListCostAllocationTagsRequest request) 
        {
            return new ListCostAllocationTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCostCategoryDefinitions operation
        ///</summary>
        public IListCostCategoryDefinitionsPaginator ListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request) 
        {
            return new ListCostCategoryDefinitionsPaginator(this.client, request);
        }
    }
}