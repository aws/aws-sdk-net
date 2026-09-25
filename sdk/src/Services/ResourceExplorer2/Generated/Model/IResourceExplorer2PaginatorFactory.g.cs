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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Paginators for the ResourceExplorer2 service
    /// </summary>
    public interface IResourceExplorer2PaginatorFactory
    {
        /// <summary>
        /// Paginator for GetResourceExplorerSetup operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetResourceExplorerSetupPaginator GetResourceExplorerSetup(GetResourceExplorerSetupRequest request);

        /// <summary>
        /// Paginator for ListIndexes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndexesPaginator ListIndexes(ListIndexesRequest request);

        /// <summary>
        /// Paginator for ListIndexesForMembers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndexesForMembersPaginator ListIndexesForMembers(ListIndexesForMembersRequest request);

        /// <summary>
        /// Paginator for ListManagedViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedViewsPaginator ListManagedViews(ListManagedViewsRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceIndexes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceIndexesPaginator ListServiceIndexes(ListServiceIndexesRequest request);

        /// <summary>
        /// Paginator for ListServiceViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceViewsPaginator ListServiceViews(ListServiceViewsRequest request);

        /// <summary>
        /// Paginator for ListStreamingAccessForServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListStreamingAccessForServicesPaginator ListStreamingAccessForServices(ListStreamingAccessForServicesRequest request);

        /// <summary>
        /// Paginator for ListSupportedResourceTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSupportedResourceTypesPaginator ListSupportedResourceTypes(ListSupportedResourceTypesRequest request);

        /// <summary>
        /// Paginator for ListViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListViewsPaginator ListViews(ListViewsRequest request);

        /// <summary>
        /// Paginator for Search operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchPaginator Search(SearchRequest request);
    }
}
