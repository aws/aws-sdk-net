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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Paginators for the CloudWatch service
    ///</summary>
    public class CloudWatchPaginatorFactory : ICloudWatchPaginatorFactory
    {
        private readonly IAmazonCloudWatch client;

        internal CloudWatchPaginatorFactory(IAmazonCloudWatch client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAlarmHistory operation
        ///</summary>
        public IDescribeAlarmHistoryPaginator DescribeAlarmHistory(DescribeAlarmHistoryRequest request) 
        {
            return new DescribeAlarmHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAlarms operation
        ///</summary>
        public IDescribeAlarmsPaginator DescribeAlarms(DescribeAlarmsRequest request) 
        {
            return new DescribeAlarmsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAnomalyDetectors operation
        ///</summary>
        public IDescribeAnomalyDetectorsPaginator DescribeAnomalyDetectors(DescribeAnomalyDetectorsRequest request) 
        {
            return new DescribeAnomalyDetectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInsightRules operation
        ///</summary>
        public IDescribeInsightRulesPaginator DescribeInsightRules(DescribeInsightRulesRequest request) 
        {
            return new DescribeInsightRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        public IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request) 
        {
            return new GetMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        public IListDashboardsPaginator ListDashboards(ListDashboardsRequest request) 
        {
            return new ListDashboardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedInsightRules operation
        ///</summary>
        public IListManagedInsightRulesPaginator ListManagedInsightRules(ListManagedInsightRulesRequest request) 
        {
            return new ListManagedInsightRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetrics operation
        ///</summary>
        public IListMetricsPaginator ListMetrics(ListMetricsRequest request) 
        {
            return new ListMetricsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMetricStreams operation
        ///</summary>
        public IListMetricStreamsPaginator ListMetricStreams(ListMetricStreamsRequest request) 
        {
            return new ListMetricStreamsPaginator(this.client, request);
        }
    }
}