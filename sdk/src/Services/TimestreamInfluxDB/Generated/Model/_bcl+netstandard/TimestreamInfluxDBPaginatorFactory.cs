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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Paginators for the TimestreamInfluxDB service
    ///</summary>
    public class TimestreamInfluxDBPaginatorFactory : ITimestreamInfluxDBPaginatorFactory
    {
        private readonly IAmazonTimestreamInfluxDB client;

        internal TimestreamInfluxDBPaginatorFactory(IAmazonTimestreamInfluxDB client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDbClusters operation
        ///</summary>
        public IListDbClustersPaginator ListDbClusters(ListDbClustersRequest request) 
        {
            return new ListDbClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbInstances operation
        ///</summary>
        public IListDbInstancesPaginator ListDbInstances(ListDbInstancesRequest request) 
        {
            return new ListDbInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbInstancesForCluster operation
        ///</summary>
        public IListDbInstancesForClusterPaginator ListDbInstancesForCluster(ListDbInstancesForClusterRequest request) 
        {
            return new ListDbInstancesForClusterPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDbParameterGroups operation
        ///</summary>
        public IListDbParameterGroupsPaginator ListDbParameterGroups(ListDbParameterGroupsRequest request) 
        {
            return new ListDbParameterGroupsPaginator(this.client, request);
        }
    }
}