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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAnomalyDetectionExecutionsPaginator DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request);

        /// <summary>
        /// Paginator for GetFeedback operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFeedbackPaginator GetFeedback(GetFeedbackRequest request);

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAlertsPaginator ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Paginator for ListAnomalyDetectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomalyDetectorsPaginator ListAnomalyDetectors(ListAnomalyDetectorsRequest request);

        /// <summary>
        /// Paginator for ListAnomalyGroupRelatedMetrics operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomalyGroupRelatedMetricsPaginator ListAnomalyGroupRelatedMetrics(ListAnomalyGroupRelatedMetricsRequest request);

        /// <summary>
        /// Paginator for ListAnomalyGroupSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomalyGroupSummariesPaginator ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request);

        /// <summary>
        /// Paginator for ListAnomalyGroupTimeSeries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomalyGroupTimeSeriesPaginator ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request);

        /// <summary>
        /// Paginator for ListMetricSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMetricSetsPaginator ListMetricSets(ListMetricSetsRequest request);
    }
}