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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Paginators for the ResourceExplorer2 service
    ///</summary>
    public class ResourceExplorer2PaginatorFactory : IResourceExplorer2PaginatorFactory
    {
        private readonly IAmazonResourceExplorer2 client;

        internal ResourceExplorer2PaginatorFactory(IAmazonResourceExplorer2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIndexes operation
        ///</summary>
        public IListIndexesPaginator ListIndexes(ListIndexesRequest request) 
        {
            return new ListIndexesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndexesForMembers operation
        ///</summary>
        public IListIndexesForMembersPaginator ListIndexesForMembers(ListIndexesForMembersRequest request) 
        {
            return new ListIndexesForMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedViews operation
        ///</summary>
        public IListManagedViewsPaginator ListManagedViews(ListManagedViewsRequest request) 
        {
            return new ListManagedViewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSupportedResourceTypes operation
        ///</summary>
        public IListSupportedResourceTypesPaginator ListSupportedResourceTypes(ListSupportedResourceTypesRequest request) 
        {
            return new ListSupportedResourceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListViews operation
        ///</summary>
        public IListViewsPaginator ListViews(ListViewsRequest request) 
        {
            return new ListViewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        public ISearchPaginator Search(SearchRequest request) 
        {
            return new SearchPaginator(this.client, request);
        }
    }
}