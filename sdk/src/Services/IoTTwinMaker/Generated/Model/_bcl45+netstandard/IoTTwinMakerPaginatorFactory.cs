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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Paginators for the IoTTwinMaker service
    ///</summary>
    public class IoTTwinMakerPaginatorFactory : IIoTTwinMakerPaginatorFactory
    {
        private readonly IAmazonIoTTwinMaker client;

        internal IoTTwinMakerPaginatorFactory(IAmazonIoTTwinMaker client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ExecuteQuery operation
        ///</summary>
        public IExecuteQueryPaginator ExecuteQuery(ExecuteQueryRequest request) 
        {
            return new ExecuteQueryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPropertyValue operation
        ///</summary>
        public IGetPropertyValuePaginator GetPropertyValue(GetPropertyValueRequest request) 
        {
            return new GetPropertyValuePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetPropertyValueHistory operation
        ///</summary>
        public IGetPropertyValueHistoryPaginator GetPropertyValueHistory(GetPropertyValueHistoryRequest request) 
        {
            return new GetPropertyValueHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponentTypes operation
        ///</summary>
        public IListComponentTypesPaginator ListComponentTypes(ListComponentTypesRequest request) 
        {
            return new ListComponentTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntities operation
        ///</summary>
        public IListEntitiesPaginator ListEntities(ListEntitiesRequest request) 
        {
            return new ListEntitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScenes operation
        ///</summary>
        public IListScenesPaginator ListScenes(ListScenesRequest request) 
        {
            return new ListScenesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSyncJobs operation
        ///</summary>
        public IListSyncJobsPaginator ListSyncJobs(ListSyncJobsRequest request) 
        {
            return new ListSyncJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSyncResources operation
        ///</summary>
        public IListSyncResourcesPaginator ListSyncResources(ListSyncResourcesRequest request) 
        {
            return new ListSyncResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        public IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request) 
        {
            return new ListWorkspacesPaginator(this.client, request);
        }
    }
}