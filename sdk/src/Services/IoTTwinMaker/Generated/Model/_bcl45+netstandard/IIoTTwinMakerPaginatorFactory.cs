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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Paginators for the IoTTwinMaker service
    ///</summary>
    public interface IIoTTwinMakerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ExecuteQuery operation
        ///</summary>
        IExecuteQueryPaginator ExecuteQuery(ExecuteQueryRequest request);

        /// <summary>
        /// Paginator for GetPropertyValue operation
        ///</summary>
        IGetPropertyValuePaginator GetPropertyValue(GetPropertyValueRequest request);

        /// <summary>
        /// Paginator for GetPropertyValueHistory operation
        ///</summary>
        IGetPropertyValueHistoryPaginator GetPropertyValueHistory(GetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for ListComponentTypes operation
        ///</summary>
        IListComponentTypesPaginator ListComponentTypes(ListComponentTypesRequest request);

        /// <summary>
        /// Paginator for ListEntities operation
        ///</summary>
        IListEntitiesPaginator ListEntities(ListEntitiesRequest request);

        /// <summary>
        /// Paginator for ListScenes operation
        ///</summary>
        IListScenesPaginator ListScenes(ListScenesRequest request);

        /// <summary>
        /// Paginator for ListSyncJobs operation
        ///</summary>
        IListSyncJobsPaginator ListSyncJobs(ListSyncJobsRequest request);

        /// <summary>
        /// Paginator for ListSyncResources operation
        ///</summary>
        IListSyncResourcesPaginator ListSyncResources(ListSyncResourcesRequest request);

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request);
    }
}