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

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Paginators for the TimestreamInfluxDB service
    /// </summary>
    public interface ITimestreamInfluxDBPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListDbBackups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDbBackupsPaginator ListDbBackups(ListDbBackupsRequest request);

        /// <summary>
        /// Paginator for ListDbClusters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDbClustersPaginator ListDbClusters(ListDbClustersRequest request);

        /// <summary>
        /// Paginator for ListDbInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDbInstancesPaginator ListDbInstances(ListDbInstancesRequest request);

        /// <summary>
        /// Paginator for ListDbInstancesForCluster operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDbInstancesForClusterPaginator ListDbInstancesForCluster(ListDbInstancesForClusterRequest request);

        /// <summary>
        /// Paginator for ListDbParameterGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDbParameterGroupsPaginator ListDbParameterGroups(ListDbParameterGroupsRequest request);
    }
}
