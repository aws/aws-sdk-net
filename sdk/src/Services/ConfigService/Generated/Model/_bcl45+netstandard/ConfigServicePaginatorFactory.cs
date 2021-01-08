#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Paginators for the ConfigService service
    ///</summary>
    public class ConfigServicePaginatorFactory : IConfigServicePaginatorFactory
    {
        private readonly IAmazonConfigService client;

        internal ConfigServicePaginatorFactory(IAmazonConfigService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeRemediationExceptions operation
        ///</summary>
        public IDescribeRemediationExceptionsPaginator DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request) 
        {
            return new DescribeRemediationExceptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRemediationExecutionStatus operation
        ///</summary>
        public IDescribeRemediationExecutionStatusPaginator DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request) 
        {
            return new DescribeRemediationExecutionStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceConfigHistory operation
        ///</summary>
        public IGetResourceConfigHistoryPaginator GetResourceConfigHistory(GetResourceConfigHistoryRequest request) 
        {
            return new GetResourceConfigHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStoredQueries operation
        ///</summary>
        public IListStoredQueriesPaginator ListStoredQueries(ListStoredQueriesRequest request) 
        {
            return new ListStoredQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SelectAggregateResourceConfig operation
        ///</summary>
        public ISelectAggregateResourceConfigPaginator SelectAggregateResourceConfig(SelectAggregateResourceConfigRequest request) 
        {
            return new SelectAggregateResourceConfigPaginator(this.client, request);
        }
    }
}
#endif