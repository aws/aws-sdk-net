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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Paginators for the DataExchange service
    ///</summary>
    public interface IDataExchangePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDataGrants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataGrantsPaginator ListDataGrants(ListDataGrantsRequest request);

        /// <summary>
        /// Paginator for ListDataSetRevisions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataSetRevisionsPaginator ListDataSetRevisions(ListDataSetRevisionsRequest request);

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataSetsPaginator ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Paginator for ListEventActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventActionsPaginator ListEventActions(ListEventActionsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListReceivedDataGrants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReceivedDataGrantsPaginator ListReceivedDataGrants(ListReceivedDataGrantsRequest request);

        /// <summary>
        /// Paginator for ListRevisionAssets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRevisionAssetsPaginator ListRevisionAssets(ListRevisionAssetsRequest request);
    }
}