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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// Paginators for the ManagedBlockchainQuery service
    ///</summary>
    public interface IManagedBlockchainQueryPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssetContracts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetContractsPaginator ListAssetContracts(ListAssetContractsRequest request);

        /// <summary>
        /// Paginator for ListFilteredTransactionEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFilteredTransactionEventsPaginator ListFilteredTransactionEvents(ListFilteredTransactionEventsRequest request);

        /// <summary>
        /// Paginator for ListTokenBalances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTokenBalancesPaginator ListTokenBalances(ListTokenBalancesRequest request);

        /// <summary>
        /// Paginator for ListTransactionEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTransactionEventsPaginator ListTransactionEvents(ListTransactionEventsRequest request);

        /// <summary>
        /// Paginator for ListTransactions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTransactionsPaginator ListTransactions(ListTransactionsRequest request);
    }
}