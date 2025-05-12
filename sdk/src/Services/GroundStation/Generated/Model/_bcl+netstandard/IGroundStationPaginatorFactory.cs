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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigsPaginator ListConfigs(ListConfigsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListDataflowEndpointGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataflowEndpointGroupsPaginator ListDataflowEndpointGroups(ListDataflowEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListEphemerides operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEphemeridesPaginator ListEphemerides(ListEphemeridesRequest request);

        /// <summary>
        /// Paginator for ListGroundStations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroundStationsPaginator ListGroundStations(ListGroundStationsRequest request);

        /// <summary>
        /// Paginator for ListMissionProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMissionProfilesPaginator ListMissionProfiles(ListMissionProfilesRequest request);

        /// <summary>
        /// Paginator for ListSatellites operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSatellitesPaginator ListSatellites(ListSatellitesRequest request);
    }
}