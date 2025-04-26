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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Paginators for the AppFabric service
    ///</summary>
    public interface IAppFabricPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAppAuthorizations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppAuthorizationsPaginator ListAppAuthorizations(ListAppAuthorizationsRequest request);

        /// <summary>
        /// Paginator for ListAppBundles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAppBundlesPaginator ListAppBundles(ListAppBundlesRequest request);

        /// <summary>
        /// Paginator for ListIngestionDestinations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIngestionDestinationsPaginator ListIngestionDestinations(ListIngestionDestinationsRequest request);

        /// <summary>
        /// Paginator for ListIngestions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIngestionsPaginator ListIngestions(ListIngestionsRequest request);
    }
}