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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Paginators for the OpenSearchMemory service
    /// </summary>
    public interface IOpenSearchMemoryPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventsPaginator ListEvents(ListEventsRequest request);

        /// <summary>
        /// Paginator for ListMemories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMemoriesPaginator ListMemories(ListMemoriesRequest request);

        /// <summary>
        /// Paginator for ListSpaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSpacesPaginator ListSpaces(ListSpacesRequest request);

        /// <summary>
        /// Paginator for SearchEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchEventsPaginator SearchEvents(SearchEventsRequest request);

        /// <summary>
        /// Paginator for SearchMemories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchMemoriesPaginator SearchMemories(SearchMemoriesRequest request);
    }
}
