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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Paginators for the TimestreamQuery service
    ///</summary>
    public class TimestreamQueryPaginatorFactory : ITimestreamQueryPaginatorFactory
    {
        private readonly IAmazonTimestreamQuery client;

        internal TimestreamQueryPaginatorFactory(IAmazonTimestreamQuery client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListScheduledQueries operation
        ///</summary>
        public IListScheduledQueriesPaginator ListScheduledQueries(ListScheduledQueriesRequest request) 
        {
            return new ListScheduledQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Query operation
        ///</summary>
        public IQueryPaginator Query(QueryRequest request) 
        {
            return new QueryPaginator(this.client, request);
        }
    }
}