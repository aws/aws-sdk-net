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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Paginators for the GroundStation service
    /// </summary>
    public interface IGroundStationPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAntennas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAntennasPaginator ListAntennas(ListAntennasRequest request);

        /// <summary>
        /// Paginator for ListConfigs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfigsPaginator ListConfigs(ListConfigsRequest request);

        /// <summary>
        /// Paginator for ListContactVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactVersionsPaginator ListContactVersions(ListContactVersionsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListDataflowEndpointGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataflowEndpointGroupsPaginator ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListEphemerides operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEphemeridesPaginator ListEphemerides(ListEphemeridesRequest request);

        /// <summary>
        /// Paginator for ListGroundStationReservations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroundStationReservationsPaginator ListGroundStationReservations(ListGroundStationReservationsRequest request);

        /// <summary>
        /// Paginator for ListGroundStations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroundStationsPaginator ListGroundStations(ListGroundStationsRequest request);

        /// <summary>
        /// Paginator for ListMissionProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMissionProfilesPaginator ListMissionProfiles(ListMissionProfilesRequest request);

        /// <summary>
        /// Paginator for ListSatellites operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSatellitesPaginator ListSatellites(ListSatellitesRequest request);
    }
}
