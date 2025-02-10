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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Paginators for the ResourceGroups service
    ///</summary>
    public class ResourceGroupsPaginatorFactory : IResourceGroupsPaginatorFactory
    {
        private readonly IAmazonResourceGroups client;

        internal ResourceGroupsPaginatorFactory(IAmazonResourceGroups client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListGroupingStatuses operation
        ///</summary>
        public IListGroupingStatusesPaginator ListGroupingStatuses(ListGroupingStatusesRequest request) 
        {
            return new ListGroupingStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupResources operation
        ///</summary>
        public IListGroupResourcesPaginator ListGroupResources(ListGroupResourcesRequest request) 
        {
            return new ListGroupResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagSyncTasks operation
        ///</summary>
        public IListTagSyncTasksPaginator ListTagSyncTasks(ListTagSyncTasksRequest request) 
        {
            return new ListTagSyncTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchResources operation
        ///</summary>
        public ISearchResourcesPaginator SearchResources(SearchResourcesRequest request) 
        {
            return new SearchResourcesPaginator(this.client, request);
        }
    }
}