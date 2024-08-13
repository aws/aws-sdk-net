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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Paginators for the ForecastService service
    ///</summary>
    public class ForecastServicePaginatorFactory : IForecastServicePaginatorFactory
    {
        private readonly IAmazonForecastService client;

        internal ForecastServicePaginatorFactory(IAmazonForecastService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDatasetGroups operation
        ///</summary>
        public IListDatasetGroupsPaginator ListDatasetGroups(ListDatasetGroupsRequest request) 
        {
            return new ListDatasetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetImportJobs operation
        ///</summary>
        public IListDatasetImportJobsPaginator ListDatasetImportJobs(ListDatasetImportJobsRequest request) 
        {
            return new ListDatasetImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExplainabilities operation
        ///</summary>
        public IListExplainabilitiesPaginator ListExplainabilities(ListExplainabilitiesRequest request) 
        {
            return new ListExplainabilitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExplainabilityExports operation
        ///</summary>
        public IListExplainabilityExportsPaginator ListExplainabilityExports(ListExplainabilityExportsRequest request) 
        {
            return new ListExplainabilityExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListForecastExportJobs operation
        ///</summary>
        public IListForecastExportJobsPaginator ListForecastExportJobs(ListForecastExportJobsRequest request) 
        {
            return new ListForecastExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListForecasts operation
        ///</summary>
        public IListForecastsPaginator ListForecasts(ListForecastsRequest request) 
        {
            return new ListForecastsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitorEvaluations operation
        ///</summary>
        public IListMonitorEvaluationsPaginator ListMonitorEvaluations(ListMonitorEvaluationsRequest request) 
        {
            return new ListMonitorEvaluationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        public IListMonitorsPaginator ListMonitors(ListMonitorsRequest request) 
        {
            return new ListMonitorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPredictorBacktestExportJobs operation
        ///</summary>
        public IListPredictorBacktestExportJobsPaginator ListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request) 
        {
            return new ListPredictorBacktestExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPredictors operation
        ///</summary>
        public IListPredictorsPaginator ListPredictors(ListPredictorsRequest request) 
        {
            return new ListPredictorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWhatIfAnalyses operation
        ///</summary>
        public IListWhatIfAnalysesPaginator ListWhatIfAnalyses(ListWhatIfAnalysesRequest request) 
        {
            return new ListWhatIfAnalysesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWhatIfForecastExports operation
        ///</summary>
        public IListWhatIfForecastExportsPaginator ListWhatIfForecastExports(ListWhatIfForecastExportsRequest request) 
        {
            return new ListWhatIfForecastExportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWhatIfForecasts operation
        ///</summary>
        public IListWhatIfForecastsPaginator ListWhatIfForecasts(ListWhatIfForecastsRequest request) 
        {
            return new ListWhatIfForecastsPaginator(this.client, request);
        }
    }
}