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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Paginators for the ConfigService service
    ///</summary>
    public interface IConfigServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeRemediationExceptions operation
        ///</summary>
        IDescribeRemediationExceptionsPaginator DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request);

        /// <summary>
        /// Paginator for DescribeRemediationExecutionStatus operation
        ///</summary>
        IDescribeRemediationExecutionStatusPaginator DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request);

        /// <summary>
        /// Paginator for GetResourceConfigHistory operation
        ///</summary>
        IGetResourceConfigHistoryPaginator GetResourceConfigHistory(GetResourceConfigHistoryRequest request);

        /// <summary>
        /// Paginator for ListStoredQueries operation
        ///</summary>
        IListStoredQueriesPaginator ListStoredQueries(ListStoredQueriesRequest request);

        /// <summary>
        /// Paginator for SelectAggregateResourceConfig operation
        ///</summary>
        ISelectAggregateResourceConfigPaginator SelectAggregateResourceConfig(SelectAggregateResourceConfigRequest request);
    }
}
#endif