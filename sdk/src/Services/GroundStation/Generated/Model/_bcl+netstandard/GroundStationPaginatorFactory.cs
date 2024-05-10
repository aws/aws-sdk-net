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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Paginators for the GroundStation service
    ///</summary>
    public class GroundStationPaginatorFactory : IGroundStationPaginatorFactory
    {
        private readonly IAmazonGroundStation client;

        internal GroundStationPaginatorFactory(IAmazonGroundStation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListConfigs operation
        ///</summary>
        public IListConfigsPaginator ListConfigs(ListConfigsRequest request) 
        {
            return new ListConfigsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        public IListContactsPaginator ListContacts(ListContactsRequest request) 
        {
            return new ListContactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataflowEndpointGroups operation
        ///</summary>
        public IListDataflowEndpointGroupsPaginator ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request) 
        {
            return new ListDataflowEndpointGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEphemerides operation
        ///</summary>
        public IListEphemeridesPaginator ListEphemerides(ListEphemeridesRequest request) 
        {
            return new ListEphemeridesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroundStations operation
        ///</summary>
        public IListGroundStationsPaginator ListGroundStations(ListGroundStationsRequest request) 
        {
            return new ListGroundStationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMissionProfiles operation
        ///</summary>
        public IListMissionProfilesPaginator ListMissionProfiles(ListMissionProfilesRequest request) 
        {
            return new ListMissionProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSatellites operation
        ///</summary>
        public IListSatellitesPaginator ListSatellites(ListSatellitesRequest request) 
        {
            return new ListSatellitesPaginator(this.client, request);
        }
    }
}