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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Paginators for the DataExchange service
    ///</summary>
    public class DataExchangePaginatorFactory : IDataExchangePaginatorFactory
    {
        private readonly IAmazonDataExchange client;

        internal DataExchangePaginatorFactory(IAmazonDataExchange client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDataGrants operation
        ///</summary>
        public IListDataGrantsPaginator ListDataGrants(ListDataGrantsRequest request) 
        {
            return new ListDataGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSetRevisions operation
        ///</summary>
        public IListDataSetRevisionsPaginator ListDataSetRevisions(ListDataSetRevisionsRequest request) 
        {
            return new ListDataSetRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        public IListDataSetsPaginator ListDataSets(ListDataSetsRequest request) 
        {
            return new ListDataSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventActions operation
        ///</summary>
        public IListEventActionsPaginator ListEventActions(ListEventActionsRequest request) 
        {
            return new ListEventActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReceivedDataGrants operation
        ///</summary>
        public IListReceivedDataGrantsPaginator ListReceivedDataGrants(ListReceivedDataGrantsRequest request) 
        {
            return new ListReceivedDataGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRevisionAssets operation
        ///</summary>
        public IListRevisionAssetsPaginator ListRevisionAssets(ListRevisionAssetsRequest request) 
        {
            return new ListRevisionAssetsPaginator(this.client, request);
        }
    }
}