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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Paginators for the LookoutMetrics service
    ///</summary>
    public class LookoutMetricsPaginatorFactory : ILookoutMetricsPaginatorFactory
    {
        private readonly IAmazonLookoutMetrics client;

        internal LookoutMetricsPaginatorFactory(IAmazonLookoutMetrics client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAnomalyDetectionExecutions operation
        ///</summary>
        public IDescribeAnomalyDetectionExecutionsPaginator DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request) 
        {
            return new DescribeAnomalyDetectionExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetFeedback operation
        ///</summary>
        public IGetFeedbackPaginator GetFeedback(GetFeedbackRequest request) 
        {
            return new GetFeedbackPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        public IListAlertsPaginator ListAlerts(ListAlertsRequest request) 
        {
            return new ListAlertsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnomalyDetectors operation
        ///</summary>
        public IListAnomalyDetectorsPaginator ListAnomalyDetectors(ListAnomalyDetectorsRequest request) 
        {
            return new ListAnomalyDetectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnomalyGroupRelatedMetrics operation
        ///</summary>
        public IListAnomalyGroupRelatedMetricsPaginator ListAnomalyGroupRelatedMetrics(ListAnomalyGroupRelatedMetricsRequest request) 
        {
            return new ListAnomalyGroupRelatedMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnomalyGroupSummaries operation
        ///</summary>
        public IListAnomalyGroupSummariesPaginator ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request) 
        {
            return new ListAnomalyGroupSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnomalyGroupTimeSeries operation
        ///</summary>
        public IListAnomalyGroupTimeSeriesPaginator ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request) 
        {
            return new ListAnomalyGroupTimeSeriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetricSets operation
        ///</summary>
        public IListMetricSetsPaginator ListMetricSets(ListMetricSetsRequest request) 
        {
            return new ListMetricSetsPaginator(this.client, request);
        }
    }
}