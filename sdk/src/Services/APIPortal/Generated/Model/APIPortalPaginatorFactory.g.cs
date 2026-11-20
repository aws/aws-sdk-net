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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
#pragma warning disable CS0612,CS0618

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Paginators for the APIPortal service
    /// </summary>
    public class APIPortalPaginatorFactory : IAPIPortalPaginatorFactory
    {
        private readonly IAmazonAPIPortal client;

        internal APIPortalPaginatorFactory(IAmazonAPIPortal client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApiInventoryItems operation
        /// </summary>
        public IListApiInventoryItemsPaginator ListApiInventoryItems(ListApiInventoryItemsRequest request)
        {
            return new ListApiInventoryItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDiscoveryStatuses operation
        /// </summary>
        public IListDiscoveryStatusesPaginator ListDiscoveryStatuses(ListDiscoveryStatusesRequest request)
        {
            return new ListDiscoveryStatusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedApiEvents operation
        /// </summary>
        public IListManagedApiEventsPaginator ListManagedApiEvents(ListManagedApiEventsRequest request)
        {
            return new ListManagedApiEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedApis operation
        /// </summary>
        public IListManagedApisPaginator ListManagedApis(ListManagedApisRequest request)
        {
            return new ListManagedApisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortals operation
        /// </summary>
        public IListPortalsPaginator ListPortals(ListPortalsRequest request)
        {
            return new ListPortalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProductApiPages operation
        /// </summary>
        public IListProductApiPagesPaginator ListProductApiPages(ListProductApiPagesRequest request)
        {
            return new ListProductApiPagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProductPages operation
        /// </summary>
        public IListProductPagesPaginator ListProductPages(ListProductPagesRequest request)
        {
            return new ListProductPagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProducts operation
        /// </summary>
        public IListProductsPaginator ListProducts(ListProductsRequest request)
        {
            return new ListProductsPaginator(this.client, request);
        }
    }
}
