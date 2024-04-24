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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Paginators for the SecurityLake service
    ///</summary>
    public class SecurityLakePaginatorFactory : ISecurityLakePaginatorFactory
    {
        private readonly IAmazonSecurityLake client;

        internal SecurityLakePaginatorFactory(IAmazonSecurityLake client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetDataLakeSources operation
        ///</summary>
        public IGetDataLakeSourcesPaginator GetDataLakeSources(GetDataLakeSourcesRequest request) 
        {
            return new GetDataLakeSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataLakeExceptions operation
        ///</summary>
        public IListDataLakeExceptionsPaginator ListDataLakeExceptions(ListDataLakeExceptionsRequest request) 
        {
            return new ListDataLakeExceptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLogSources operation
        ///</summary>
        public IListLogSourcesPaginator ListLogSources(ListLogSourcesRequest request) 
        {
            return new ListLogSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscribers operation
        ///</summary>
        public IListSubscribersPaginator ListSubscribers(ListSubscribersRequest request) 
        {
            return new ListSubscribersPaginator(this.client, request);
        }
    }
}