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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Paginators for the SnowDeviceManagement service
    ///</summary>
    public class SnowDeviceManagementPaginatorFactory : ISnowDeviceManagementPaginatorFactory
    {
        private readonly IAmazonSnowDeviceManagement client;

        internal SnowDeviceManagementPaginatorFactory(IAmazonSnowDeviceManagement client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDeviceResources operation
        ///</summary>
        public IListDeviceResourcesPaginator ListDeviceResources(ListDeviceResourcesRequest request) 
        {
            return new ListDeviceResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        public IListDevicesPaginator ListDevices(ListDevicesRequest request) 
        {
            return new ListDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        public IListExecutionsPaginator ListExecutions(ListExecutionsRequest request) 
        {
            return new ListExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTasks operation
        ///</summary>
        public IListTasksPaginator ListTasks(ListTasksRequest request) 
        {
            return new ListTasksPaginator(this.client, request);
        }
    }
}