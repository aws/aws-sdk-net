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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Paginators for the LocationService service
    ///</summary>
    public interface ILocationServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetDevicePositionHistory operation
        ///</summary>
        IGetDevicePositionHistoryPaginator GetDevicePositionHistory(GetDevicePositionHistoryRequest request);

        /// <summary>
        /// Paginator for ListDevicePositions operation
        ///</summary>
        IListDevicePositionsPaginator ListDevicePositions(ListDevicePositionsRequest request);

        /// <summary>
        /// Paginator for ListGeofenceCollections operation
        ///</summary>
        IListGeofenceCollectionsPaginator ListGeofenceCollections(ListGeofenceCollectionsRequest request);

        /// <summary>
        /// Paginator for ListGeofences operation
        ///</summary>
        IListGeofencesPaginator ListGeofences(ListGeofencesRequest request);

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        IListKeysPaginator ListKeys(ListKeysRequest request);

        /// <summary>
        /// Paginator for ListMaps operation
        ///</summary>
        IListMapsPaginator ListMaps(ListMapsRequest request);

        /// <summary>
        /// Paginator for ListPlaceIndexes operation
        ///</summary>
        IListPlaceIndexesPaginator ListPlaceIndexes(ListPlaceIndexesRequest request);

        /// <summary>
        /// Paginator for ListRouteCalculators operation
        ///</summary>
        IListRouteCalculatorsPaginator ListRouteCalculators(ListRouteCalculatorsRequest request);

        /// <summary>
        /// Paginator for ListTrackerConsumers operation
        ///</summary>
        IListTrackerConsumersPaginator ListTrackerConsumers(ListTrackerConsumersRequest request);

        /// <summary>
        /// Paginator for ListTrackers operation
        ///</summary>
        IListTrackersPaginator ListTrackers(ListTrackersRequest request);
    }
}