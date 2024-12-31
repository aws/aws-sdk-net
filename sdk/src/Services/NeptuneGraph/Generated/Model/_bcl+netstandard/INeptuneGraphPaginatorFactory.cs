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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Paginators for the NeptuneGraph service
    ///</summary>
    public interface INeptuneGraphPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListExportTasks operation
        ///</summary>
        IListExportTasksPaginator ListExportTasks(ListExportTasksRequest request);

        /// <summary>
        /// Paginator for ListGraphs operation
        ///</summary>
        IListGraphsPaginator ListGraphs(ListGraphsRequest request);

        /// <summary>
        /// Paginator for ListGraphSnapshots operation
        ///</summary>
        IListGraphSnapshotsPaginator ListGraphSnapshots(ListGraphSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListImportTasks operation
        ///</summary>
        IListImportTasksPaginator ListImportTasks(ListImportTasksRequest request);

        /// <summary>
        /// Paginator for ListPrivateGraphEndpoints operation
        ///</summary>
        IListPrivateGraphEndpointsPaginator ListPrivateGraphEndpoints(ListPrivateGraphEndpointsRequest request);
    }
}