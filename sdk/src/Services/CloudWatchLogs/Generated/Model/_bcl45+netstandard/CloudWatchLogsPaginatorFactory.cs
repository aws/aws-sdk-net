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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Paginators for the CloudWatchLogs service
    ///</summary>
    public class CloudWatchLogsPaginatorFactory : ICloudWatchLogsPaginatorFactory
    {
        private readonly IAmazonCloudWatchLogs client;

        internal CloudWatchLogsPaginatorFactory(IAmazonCloudWatchLogs client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeDestinations operation
        ///</summary>
        public IDescribeDestinationsPaginator DescribeDestinations(DescribeDestinationsRequest request) 
        {
            return new DescribeDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLogGroups operation
        ///</summary>
        public IDescribeLogGroupsPaginator DescribeLogGroups(DescribeLogGroupsRequest request) 
        {
            return new DescribeLogGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLogStreams operation
        ///</summary>
        public IDescribeLogStreamsPaginator DescribeLogStreams(DescribeLogStreamsRequest request) 
        {
            return new DescribeLogStreamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMetricFilters operation
        ///</summary>
        public IDescribeMetricFiltersPaginator DescribeMetricFilters(DescribeMetricFiltersRequest request) 
        {
            return new DescribeMetricFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSubscriptionFilters operation
        ///</summary>
        public IDescribeSubscriptionFiltersPaginator DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request) 
        {
            return new DescribeSubscriptionFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for FilterLogEvents operation
        ///</summary>
        public IFilterLogEventsPaginator FilterLogEvents(FilterLogEventsRequest request) 
        {
            return new FilterLogEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetLogEvents operation
        ///</summary>
        public IGetLogEventsPaginator GetLogEvents(GetLogEventsRequest request) 
        {
            return new GetLogEventsPaginator(this.client, request);
        }
    }
}
#endif