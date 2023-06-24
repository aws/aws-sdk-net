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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Paginators for the IoTRoboRunner service
    ///</summary>
    public class IoTRoboRunnerPaginatorFactory : IIoTRoboRunnerPaginatorFactory
    {
        private readonly IAmazonIoTRoboRunner client;

        internal IoTRoboRunnerPaginatorFactory(IAmazonIoTRoboRunner client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        public IListDestinationsPaginator ListDestinations(ListDestinationsRequest request) 
        {
            return new ListDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSites operation
        ///</summary>
        public IListSitesPaginator ListSites(ListSitesRequest request) 
        {
            return new ListSitesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkerFleets operation
        ///</summary>
        public IListWorkerFleetsPaginator ListWorkerFleets(ListWorkerFleetsRequest request) 
        {
            return new ListWorkerFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkers operation
        ///</summary>
        public IListWorkersPaginator ListWorkers(ListWorkersRequest request) 
        {
            return new ListWorkersPaginator(this.client, request);
        }
    }
}