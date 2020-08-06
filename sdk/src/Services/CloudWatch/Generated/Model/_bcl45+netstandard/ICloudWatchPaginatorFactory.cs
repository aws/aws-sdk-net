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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Paginators for the CloudWatch service
    ///</summary>
    public interface ICloudWatchPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAlarmHistory operation
        ///</summary>
        IDescribeAlarmHistoryPaginator DescribeAlarmHistory(DescribeAlarmHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeAlarms operation
        ///</summary>
        IDescribeAlarmsPaginator DescribeAlarms(DescribeAlarmsRequest request);

        /// <summary>
        /// Paginator for DescribeInsightRules operation
        ///</summary>
        IDescribeInsightRulesPaginator DescribeInsightRules(DescribeInsightRulesRequest request);

        /// <summary>
        /// Paginator for GetMetricData operation
        ///</summary>
        IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListMetrics operation
        ///</summary>
        IListMetricsPaginator ListMetrics(ListMetricsRequest request);
    }
}
#endif