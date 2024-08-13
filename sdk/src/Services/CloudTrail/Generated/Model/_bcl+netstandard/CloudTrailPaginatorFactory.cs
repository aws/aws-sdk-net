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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Paginators for the CloudTrail service
    ///</summary>
    public class CloudTrailPaginatorFactory : ICloudTrailPaginatorFactory
    {
        private readonly IAmazonCloudTrail client;

        internal CloudTrailPaginatorFactory(IAmazonCloudTrail client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetQueryResults operation
        ///</summary>
        public IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request) 
        {
            return new GetQueryResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventDataStores operation
        ///</summary>
        public IListEventDataStoresPaginator ListEventDataStores(ListEventDataStoresRequest request) 
        {
            return new ListEventDataStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImportFailures operation
        ///</summary>
        public IListImportFailuresPaginator ListImportFailures(ListImportFailuresRequest request) 
        {
            return new ListImportFailuresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        public IListImportsPaginator ListImports(ListImportsRequest request) 
        {
            return new ListImportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInsightsMetricData operation
        ///</summary>
        public IListInsightsMetricDataPaginator ListInsightsMetricData(ListInsightsMetricDataRequest request) 
        {
            return new ListInsightsMetricDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        public IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request) 
        {
            return new ListPublicKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueries operation
        ///</summary>
        public IListQueriesPaginator ListQueries(ListQueriesRequest request) 
        {
            return new ListQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTrails operation
        ///</summary>
        public IListTrailsPaginator ListTrails(ListTrailsRequest request) 
        {
            return new ListTrailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for LookupEvents operation
        ///</summary>
        public ILookupEventsPaginator LookupEvents(LookupEventsRequest request) 
        {
            return new LookupEventsPaginator(this.client, request);
        }
    }
}