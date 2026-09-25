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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Paginators for the LocationService service
    /// </summary>
    public interface ILocationServicePaginatorFactory
    {
        /// <summary>
        /// Paginator for ForecastGeofenceEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IForecastGeofenceEventsPaginator ForecastGeofenceEvents(ForecastGeofenceEventsRequest request);

        /// <summary>
        /// Paginator for GetDevicePositionHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetDevicePositionHistoryPaginator GetDevicePositionHistory(GetDevicePositionHistoryRequest request);

        /// <summary>
        /// Paginator for ListDevicePositions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDevicePositionsPaginator ListDevicePositions(ListDevicePositionsRequest request);

        /// <summary>
        /// Paginator for ListGeofenceCollections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGeofenceCollectionsPaginator ListGeofenceCollections(ListGeofenceCollectionsRequest request);

        /// <summary>
        /// Paginator for ListGeofences operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGeofencesPaginator ListGeofences(ListGeofencesRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKeysPaginator ListKeys(ListKeysRequest request);

        /// <summary>
        /// Paginator for ListMaps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMapsPaginator ListMaps(ListMapsRequest request);

        /// <summary>
        /// Paginator for ListPlaceIndexes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPlaceIndexesPaginator ListPlaceIndexes(ListPlaceIndexesRequest request);

        /// <summary>
        /// Paginator for ListRouteCalculators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRouteCalculatorsPaginator ListRouteCalculators(ListRouteCalculatorsRequest request);

        /// <summary>
        /// Paginator for ListTrackerConsumers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrackerConsumersPaginator ListTrackerConsumers(ListTrackerConsumersRequest request);

        /// <summary>
        /// Paginator for ListTrackers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTrackersPaginator ListTrackers(ListTrackersRequest request);
    }
}
