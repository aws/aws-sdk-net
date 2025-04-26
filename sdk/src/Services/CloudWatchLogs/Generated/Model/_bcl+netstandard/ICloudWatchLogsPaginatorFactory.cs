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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Paginators for the CloudWatchLogs service
    ///</summary>
    public interface ICloudWatchLogsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeConfigurationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeConfigurationTemplatesPaginator DescribeConfigurationTemplates(DescribeConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeDeliveries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDeliveriesPaginator DescribeDeliveries(DescribeDeliveriesRequest request);

        /// <summary>
        /// Paginator for DescribeDeliveryDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDeliveryDestinationsPaginator DescribeDeliveryDestinations(DescribeDeliveryDestinationsRequest request);

        /// <summary>
        /// Paginator for DescribeDeliverySources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDeliverySourcesPaginator DescribeDeliverySources(DescribeDeliverySourcesRequest request);

        /// <summary>
        /// Paginator for DescribeDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDestinationsPaginator DescribeDestinations(DescribeDestinationsRequest request);

        /// <summary>
        /// Paginator for DescribeLogGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLogGroupsPaginator DescribeLogGroups(DescribeLogGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeLogStreams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLogStreamsPaginator DescribeLogStreams(DescribeLogStreamsRequest request);

        /// <summary>
        /// Paginator for DescribeMetricFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMetricFiltersPaginator DescribeMetricFilters(DescribeMetricFiltersRequest request);

        /// <summary>
        /// Paginator for DescribeSubscriptionFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSubscriptionFiltersPaginator DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request);

        /// <summary>
        /// Paginator for FilterLogEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IFilterLogEventsPaginator FilterLogEvents(FilterLogEventsRequest request);

        /// <summary>
        /// Paginator for GetLogEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextForwardToken" }
        )]
        IGetLogEventsPaginator GetLogEvents(GetLogEventsRequest request);

        /// <summary>
        /// Paginator for ListAnomalies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnomaliesPaginator ListAnomalies(ListAnomaliesRequest request);

        /// <summary>
        /// Paginator for ListLogAnomalyDetectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListLogAnomalyDetectorsPaginator ListLogAnomalyDetectors(ListLogAnomalyDetectorsRequest request);

        /// <summary>
        /// Paginator for ListLogGroupsForQuery operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLogGroupsForQueryPaginator ListLogGroupsForQuery(ListLogGroupsForQueryRequest request);
    }
}