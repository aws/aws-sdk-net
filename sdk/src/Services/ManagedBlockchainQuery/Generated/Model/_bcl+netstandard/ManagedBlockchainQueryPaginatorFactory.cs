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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// Paginators for the ManagedBlockchainQuery service
    ///</summary>
    public class ManagedBlockchainQueryPaginatorFactory : IManagedBlockchainQueryPaginatorFactory
    {
        private readonly IAmazonManagedBlockchainQuery client;

        internal ManagedBlockchainQueryPaginatorFactory(IAmazonManagedBlockchainQuery client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssetContracts operation
        ///</summary>
        public IListAssetContractsPaginator ListAssetContracts(ListAssetContractsRequest request) 
        {
            return new ListAssetContractsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFilteredTransactionEvents operation
        ///</summary>
        public IListFilteredTransactionEventsPaginator ListFilteredTransactionEvents(ListFilteredTransactionEventsRequest request) 
        {
            return new ListFilteredTransactionEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTokenBalances operation
        ///</summary>
        public IListTokenBalancesPaginator ListTokenBalances(ListTokenBalancesRequest request) 
        {
            return new ListTokenBalancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTransactionEvents operation
        ///</summary>
        public IListTransactionEventsPaginator ListTransactionEvents(ListTransactionEventsRequest request) 
        {
            return new ListTransactionEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTransactions operation
        ///</summary>
        public IListTransactionsPaginator ListTransactions(ListTransactionsRequest request) 
        {
            return new ListTransactionsPaginator(this.client, request);
        }
    }
}