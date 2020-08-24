#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Paginators for the CloudWatchLogs service
    ///</summary>
    public interface ICloudWatchLogsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeDestinations operation
        ///</summary>
        IDescribeDestinationsPaginator DescribeDestinations(DescribeDestinationsRequest request);

        /// <summary>
        /// Paginator for DescribeLogGroups operation
        ///</summary>
        IDescribeLogGroupsPaginator DescribeLogGroups(DescribeLogGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeLogStreams operation
        ///</summary>
        IDescribeLogStreamsPaginator DescribeLogStreams(DescribeLogStreamsRequest request);

        /// <summary>
        /// Paginator for DescribeMetricFilters operation
        ///</summary>
        IDescribeMetricFiltersPaginator DescribeMetricFilters(DescribeMetricFiltersRequest request);

        /// <summary>
        /// Paginator for DescribeSubscriptionFilters operation
        ///</summary>
        IDescribeSubscriptionFiltersPaginator DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request);

        /// <summary>
        /// Paginator for FilterLogEvents operation
        ///</summary>
        IFilterLogEventsPaginator FilterLogEvents(FilterLogEventsRequest request);

        /// <summary>
        /// Paginator for GetLogEvents operation
        ///</summary>
        IGetLogEventsPaginator GetLogEvents(GetLogEventsRequest request);
    }
}
#endif