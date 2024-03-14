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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Paginators for the IoTRoboRunner service
    ///</summary>
    public interface IIoTRoboRunnerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        IListDestinationsPaginator ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Paginator for ListSites operation
        ///</summary>
        IListSitesPaginator ListSites(ListSitesRequest request);

        /// <summary>
        /// Paginator for ListWorkerFleets operation
        ///</summary>
        IListWorkerFleetsPaginator ListWorkerFleets(ListWorkerFleetsRequest request);

        /// <summary>
        /// Paginator for ListWorkers operation
        ///</summary>
        IListWorkersPaginator ListWorkers(ListWorkersRequest request);
    }
}