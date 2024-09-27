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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model
{
    /// <summary>
    /// Paginators for the PCS service
    ///</summary>
    public class PCSPaginatorFactory : IPCSPaginatorFactory
    {
        private readonly IAmazonPCS client;

        internal PCSPaginatorFactory(IAmazonPCS client) 
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
        /// Paginator for ListComputeNodeGroups operation
        ///</summary>
        public IListComputeNodeGroupsPaginator ListComputeNodeGroups(ListComputeNodeGroupsRequest request) 
        {
            return new ListComputeNodeGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }
    }
}