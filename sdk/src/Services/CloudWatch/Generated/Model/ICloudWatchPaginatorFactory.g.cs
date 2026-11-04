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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Paginators for the CloudWatch service
    /// </summary>
    public interface ICloudWatchPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeAlarmHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeAlarmHistoryPaginator DescribeAlarmHistory(DescribeAlarmHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeAlarms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeAlarmsPaginator DescribeAlarms(DescribeAlarmsRequest request);

        /// <summary>
        /// Paginator for DescribeAnomalyDetectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeAnomalyDetectorsPaginator DescribeAnomalyDetectors(DescribeAnomalyDetectorsRequest request);

        /// <summary>
        /// Paginator for DescribeInsightRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeInsightRulesPaginator DescribeInsightRules(DescribeInsightRulesRequest request);

        /// <summary>
        /// Paginator for GetMetricData operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxDatapoints", OutputToken = ["NextToken"])]
        IGetMetricDataPaginator GetMetricData(GetMetricDataRequest request);

        /// <summary>
        /// Paginator for ListAlarmMuteRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IListAlarmMuteRulesPaginator ListAlarmMuteRules(ListAlarmMuteRulesRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListManagedInsightRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedInsightRulesPaginator ListManagedInsightRules(ListManagedInsightRulesRequest request);

        /// <summary>
        /// Paginator for ListMetricStreams operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMetricStreamsPaginator ListMetricStreams(ListMetricStreamsRequest request);

        /// <summary>
        /// Paginator for ListMetrics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListMetricsPaginator ListMetrics(ListMetricsRequest request);
    }
}
