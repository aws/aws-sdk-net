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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Paginators for the GroundStation service
    ///</summary>
    public interface IGroundStationPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListConfigs operation
        ///</summary>
        IListConfigsPaginator ListConfigs(ListConfigsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListDataflowEndpointGroups operation
        ///</summary>
        IListDataflowEndpointGroupsPaginator ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListEphemerides operation
        ///</summary>
        IListEphemeridesPaginator ListEphemerides(ListEphemeridesRequest request);

        /// <summary>
        /// Paginator for ListGroundStations operation
        ///</summary>
        IListGroundStationsPaginator ListGroundStations(ListGroundStationsRequest request);

        /// <summary>
        /// Paginator for ListMissionProfiles operation
        ///</summary>
        IListMissionProfilesPaginator ListMissionProfiles(ListMissionProfilesRequest request);

        /// <summary>
        /// Paginator for ListSatellites operation
        ///</summary>
        IListSatellitesPaginator ListSatellites(ListSatellitesRequest request);
    }
}