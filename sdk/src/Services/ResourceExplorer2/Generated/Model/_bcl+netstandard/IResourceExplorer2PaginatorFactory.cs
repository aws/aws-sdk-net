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

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Paginators for the ResourceExplorer2 service
    ///</summary>
    public interface IResourceExplorer2PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListIndexes operation
        ///</summary>
        IListIndexesPaginator ListIndexes(ListIndexesRequest request);

        /// <summary>
        /// Paginator for ListIndexesForMembers operation
        ///</summary>
        IListIndexesForMembersPaginator ListIndexesForMembers(ListIndexesForMembersRequest request);

        /// <summary>
        /// Paginator for ListSupportedResourceTypes operation
        ///</summary>
        IListSupportedResourceTypesPaginator ListSupportedResourceTypes(ListSupportedResourceTypesRequest request);

        /// <summary>
        /// Paginator for ListViews operation
        ///</summary>
        IListViewsPaginator ListViews(ListViewsRequest request);

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        ISearchPaginator Search(SearchRequest request);
    }
}