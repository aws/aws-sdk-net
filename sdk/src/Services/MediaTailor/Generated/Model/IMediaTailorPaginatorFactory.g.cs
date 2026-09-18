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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Paginators for the MediaTailor service
    /// </summary>
    public interface IMediaTailorPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetChannelSchedule operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetChannelSchedulePaginator GetChannelSchedule(GetChannelScheduleRequest request);

        /// <summary>
        /// Paginator for ListAlerts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAlertsPaginator ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFunctionsPaginator ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Paginator for ListLiveSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListLiveSourcesPaginator ListLiveSources(ListLiveSourcesRequest request);

        /// <summary>
        /// Paginator for ListPlaybackConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlaybackConfigurationsPaginator ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListPrefetchSchedules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPrefetchSchedulesPaginator ListPrefetchSchedules(ListPrefetchSchedulesRequest request);

        /// <summary>
        /// Paginator for ListSourceLocations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSourceLocationsPaginator ListSourceLocations(ListSourceLocationsRequest request);

        /// <summary>
        /// Paginator for ListVodSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVodSourcesPaginator ListVodSources(ListVodSourcesRequest request);
    }
}
