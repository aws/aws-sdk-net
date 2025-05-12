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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Paginators for the ForecastService service
    ///</summary>
    public interface IForecastServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDatasetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetGroupsPaginator ListDatasetGroups(ListDatasetGroupsRequest request);

        /// <summary>
        /// Paginator for ListDatasetImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetImportJobsPaginator ListDatasetImportJobs(ListDatasetImportJobsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListExplainabilities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExplainabilitiesPaginator ListExplainabilities(ListExplainabilitiesRequest request);

        /// <summary>
        /// Paginator for ListExplainabilityExports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExplainabilityExportsPaginator ListExplainabilityExports(ListExplainabilityExportsRequest request);

        /// <summary>
        /// Paginator for ListForecastExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListForecastExportJobsPaginator ListForecastExportJobs(ListForecastExportJobsRequest request);

        /// <summary>
        /// Paginator for ListForecasts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListForecastsPaginator ListForecasts(ListForecastsRequest request);

        /// <summary>
        /// Paginator for ListMonitorEvaluations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitorEvaluationsPaginator ListMonitorEvaluations(ListMonitorEvaluationsRequest request);

        /// <summary>
        /// Paginator for ListMonitors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMonitorsPaginator ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Paginator for ListPredictorBacktestExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPredictorBacktestExportJobsPaginator ListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request);

        /// <summary>
        /// Paginator for ListPredictors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPredictorsPaginator ListPredictors(ListPredictorsRequest request);

        /// <summary>
        /// Paginator for ListWhatIfAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWhatIfAnalysesPaginator ListWhatIfAnalyses(ListWhatIfAnalysesRequest request);

        /// <summary>
        /// Paginator for ListWhatIfForecastExports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWhatIfForecastExportsPaginator ListWhatIfForecastExports(ListWhatIfForecastExportsRequest request);

        /// <summary>
        /// Paginator for ListWhatIfForecasts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWhatIfForecastsPaginator ListWhatIfForecasts(ListWhatIfForecastsRequest request);
    }
}