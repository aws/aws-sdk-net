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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Paginators for the DocDBElastic service
    ///</summary>
    public class DocDBElasticPaginatorFactory : IDocDBElasticPaginatorFactory
    {
        private readonly IAmazonDocDBElastic client;

        internal DocDBElasticPaginatorFactory(IAmazonDocDBElastic client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusterSnapshots operation
        ///</summary>
        public IListClusterSnapshotsPaginator ListClusterSnapshots(ListClusterSnapshotsRequest request) 
        {
            return new ListClusterSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPendingMaintenanceActions operation
        ///</summary>
        public IListPendingMaintenanceActionsPaginator ListPendingMaintenanceActions(ListPendingMaintenanceActionsRequest request) 
        {
            return new ListPendingMaintenanceActionsPaginator(this.client, request);
        }
    }
}