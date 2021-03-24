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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Paginators for the LookoutMetrics service
    ///</summary>
    public interface ILookoutMetricsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAnomalyDetectionExecutions operation
        ///</summary>
        IDescribeAnomalyDetectionExecutionsPaginator DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request);

        /// <summary>
        /// Paginator for GetFeedback operation
        ///</summary>
        IGetFeedbackPaginator GetFeedback(GetFeedbackRequest request);

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        IListAlertsPaginator ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Paginator for ListAnomalyDetectors operation
        ///</summary>
        IListAnomalyDetectorsPaginator ListAnomalyDetectors(ListAnomalyDetectorsRequest request);

        /// <summary>
        /// Paginator for ListAnomalyGroupSummaries operation
        ///</summary>
        IListAnomalyGroupSummariesPaginator ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request);

        /// <summary>
        /// Paginator for ListAnomalyGroupTimeSeries operation
        ///</summary>
        IListAnomalyGroupTimeSeriesPaginator ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request);

        /// <summary>
        /// Paginator for ListMetricSets operation
        ///</summary>
        IListMetricSetsPaginator ListMetricSets(ListMetricSetsRequest request);
    }
}