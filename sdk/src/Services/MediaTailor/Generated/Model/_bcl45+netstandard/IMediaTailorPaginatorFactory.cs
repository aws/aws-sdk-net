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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Paginators for the MediaTailor service
    ///</summary>
    public interface IMediaTailorPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetChannelSchedule operation
        ///</summary>
        IGetChannelSchedulePaginator GetChannelSchedule(GetChannelScheduleRequest request);

        /// <summary>
        /// Paginator for ListAlerts operation
        ///</summary>
        IListAlertsPaginator ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListPlaybackConfigurations operation
        ///</summary>
        IListPlaybackConfigurationsPaginator ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListSourceLocations operation
        ///</summary>
        IListSourceLocationsPaginator ListSourceLocations(ListSourceLocationsRequest request);

        /// <summary>
        /// Paginator for ListVodSources operation
        ///</summary>
        IListVodSourcesPaginator ListVodSources(ListVodSourcesRequest request);
    }
}