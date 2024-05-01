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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Paginators for the AppFabric service
    ///</summary>
    public class AppFabricPaginatorFactory : IAppFabricPaginatorFactory
    {
        private readonly IAmazonAppFabric client;

        internal AppFabricPaginatorFactory(IAmazonAppFabric client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAppAuthorizations operation
        ///</summary>
        public IListAppAuthorizationsPaginator ListAppAuthorizations(ListAppAuthorizationsRequest request) 
        {
            return new ListAppAuthorizationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppBundles operation
        ///</summary>
        public IListAppBundlesPaginator ListAppBundles(ListAppBundlesRequest request) 
        {
            return new ListAppBundlesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngestionDestinations operation
        ///</summary>
        public IListIngestionDestinationsPaginator ListIngestionDestinations(ListIngestionDestinationsRequest request) 
        {
            return new ListIngestionDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngestions operation
        ///</summary>
        public IListIngestionsPaginator ListIngestions(ListIngestionsRequest request) 
        {
            return new ListIngestionsPaginator(this.client, request);
        }
    }
}