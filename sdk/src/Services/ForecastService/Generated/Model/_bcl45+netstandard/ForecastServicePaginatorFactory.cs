#if !NETSTANDARD13
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
    }
}
#endif