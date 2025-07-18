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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Paginators for the Outposts service
    ///</summary>
    public class OutpostsPaginatorFactory : IOutpostsPaginatorFactory
    {
        private readonly IAmazonOutposts client;

        internal OutpostsPaginatorFactory(IAmazonOutposts client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetOutpostBillingInformation operation
        ///</summary>
        public IGetOutpostBillingInformationPaginator GetOutpostBillingInformation(GetOutpostBillingInformationRequest request) 
        {
            return new GetOutpostBillingInformationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOutpostInstanceTypes operation
        ///</summary>
        public IGetOutpostInstanceTypesPaginator GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request) 
        {
            return new GetOutpostInstanceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetOutpostSupportedInstanceTypes operation
        ///</summary>
        public IGetOutpostSupportedInstanceTypesPaginator GetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request) 
        {
            return new GetOutpostSupportedInstanceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetInstances operation
        ///</summary>
        public IListAssetInstancesPaginator ListAssetInstances(ListAssetInstancesRequest request) 
        {
            return new ListAssetInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        public IListAssetsPaginator ListAssets(ListAssetsRequest request) 
        {
            return new ListAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBlockingInstancesForCapacityTask operation
        ///</summary>
        public IListBlockingInstancesForCapacityTaskPaginator ListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request) 
        {
            return new ListBlockingInstancesForCapacityTaskPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCapacityTasks operation
        ///</summary>
        public IListCapacityTasksPaginator ListCapacityTasks(ListCapacityTasksRequest request) 
        {
            return new ListCapacityTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCatalogItems operation
        ///</summary>
        public IListCatalogItemsPaginator ListCatalogItems(ListCatalogItemsRequest request) 
        {
            return new ListCatalogItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrders operation
        ///</summary>
        public IListOrdersPaginator ListOrders(ListOrdersRequest request) 
        {
            return new ListOrdersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOutposts operation
        ///</summary>
        public IListOutpostsPaginator ListOutposts(ListOutpostsRequest request) 
        {
            return new ListOutpostsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSites operation
        ///</summary>
        public IListSitesPaginator ListSites(ListSitesRequest request) 
        {
            return new ListSitesPaginator(this.client, request);
        }
    }
}