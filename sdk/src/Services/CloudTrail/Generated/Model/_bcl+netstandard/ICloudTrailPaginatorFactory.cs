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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Paginators for the CloudTrail service
    ///</summary>
    public interface ICloudTrailPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetQueryResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListEventDataStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventDataStoresPaginator ListEventDataStores(ListEventDataStoresRequest request);

        /// <summary>
        /// Paginator for ListImportFailures operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportFailuresPaginator ListImportFailures(ListImportFailuresRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListInsightsMetricData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInsightsMetricDataPaginator ListInsightsMetricData(ListInsightsMetricDataRequest request);

        /// <summary>
        /// Paginator for ListPublicKeys operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListPublicKeysPaginator ListPublicKeys(ListPublicKeysRequest request);

        /// <summary>
        /// Paginator for ListQueries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQueriesPaginator ListQueries(ListQueriesRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTrails operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListTrailsPaginator ListTrails(ListTrailsRequest request);

        /// <summary>
        /// Paginator for LookupEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ILookupEventsPaginator LookupEvents(LookupEventsRequest request);
    }
}