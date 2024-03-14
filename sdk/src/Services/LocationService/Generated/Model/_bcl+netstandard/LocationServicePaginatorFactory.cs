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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Paginators for the LocationService service
    ///</summary>
    public class LocationServicePaginatorFactory : ILocationServicePaginatorFactory
    {
        private readonly IAmazonLocationService client;

        internal LocationServicePaginatorFactory(IAmazonLocationService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetDevicePositionHistory operation
        ///</summary>
        public IGetDevicePositionHistoryPaginator GetDevicePositionHistory(GetDevicePositionHistoryRequest request) 
        {
            return new GetDevicePositionHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevicePositions operation
        ///</summary>
        public IListDevicePositionsPaginator ListDevicePositions(ListDevicePositionsRequest request) 
        {
            return new ListDevicePositionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGeofenceCollections operation
        ///</summary>
        public IListGeofenceCollectionsPaginator ListGeofenceCollections(ListGeofenceCollectionsRequest request) 
        {
            return new ListGeofenceCollectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGeofences operation
        ///</summary>
        public IListGeofencesPaginator ListGeofences(ListGeofencesRequest request) 
        {
            return new ListGeofencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        public IListKeysPaginator ListKeys(ListKeysRequest request) 
        {
            return new ListKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMaps operation
        ///</summary>
        public IListMapsPaginator ListMaps(ListMapsRequest request) 
        {
            return new ListMapsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlaceIndexes operation
        ///</summary>
        public IListPlaceIndexesPaginator ListPlaceIndexes(ListPlaceIndexesRequest request) 
        {
            return new ListPlaceIndexesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRouteCalculators operation
        ///</summary>
        public IListRouteCalculatorsPaginator ListRouteCalculators(ListRouteCalculatorsRequest request) 
        {
            return new ListRouteCalculatorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrackerConsumers operation
        ///</summary>
        public IListTrackerConsumersPaginator ListTrackerConsumers(ListTrackerConsumersRequest request) 
        {
            return new ListTrackerConsumersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrackers operation
        ///</summary>
        public IListTrackersPaginator ListTrackers(ListTrackersRequest request) 
        {
            return new ListTrackersPaginator(this.client, request);
        }
    }
}