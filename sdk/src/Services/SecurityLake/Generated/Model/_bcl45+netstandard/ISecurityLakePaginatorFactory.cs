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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Paginators for the SecurityLake service
    ///</summary>
    public interface ISecurityLakePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetDataLakeSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetDataLakeSourcesPaginator GetDataLakeSources(GetDataLakeSourcesRequest request);

        /// <summary>
        /// Paginator for ListDataLakeExceptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataLakeExceptionsPaginator ListDataLakeExceptions(ListDataLakeExceptionsRequest request);

        /// <summary>
        /// Paginator for ListLogSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLogSourcesPaginator ListLogSources(ListLogSourcesRequest request);

        /// <summary>
        /// Paginator for ListSubscribers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSubscribersPaginator ListSubscribers(ListSubscribersRequest request);
    }
}