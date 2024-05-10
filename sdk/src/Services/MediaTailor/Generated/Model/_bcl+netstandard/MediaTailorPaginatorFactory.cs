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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Paginators for the MediaTailor service
    ///</summary>
    public class MediaTailorPaginatorFactory : IMediaTailorPaginatorFactory
    {
        private readonly IAmazonMediaTailor client;

        internal MediaTailorPaginatorFactory(IAmazonMediaTailor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetChannelSchedule operation
        ///</summary>
        public IGetChannelSchedulePaginator GetChannelSchedule(GetChannelScheduleRequest request) 
        {
            return new GetChannelSchedulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        public IListAlertsPaginator ListAlerts(ListAlertsRequest request) 
        {
            return new ListAlertsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLiveSources operation
        ///</summary>
        public IListLiveSourcesPaginator ListLiveSources(ListLiveSourcesRequest request) 
        {
            return new ListLiveSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlaybackConfigurations operation
        ///</summary>
        public IListPlaybackConfigurationsPaginator ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request) 
        {
            return new ListPlaybackConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrefetchSchedules operation
        ///</summary>
        public IListPrefetchSchedulesPaginator ListPrefetchSchedules(ListPrefetchSchedulesRequest request) 
        {
            return new ListPrefetchSchedulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceLocations operation
        ///</summary>
        public IListSourceLocationsPaginator ListSourceLocations(ListSourceLocationsRequest request) 
        {
            return new ListSourceLocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVodSources operation
        ///</summary>
        public IListVodSourcesPaginator ListVodSources(ListVodSourcesRequest request) 
        {
            return new ListVodSourcesPaginator(this.client, request);
        }
    }
}