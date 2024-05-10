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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Paginators for the MarketplaceCatalog service
    ///</summary>
    public class MarketplaceCatalogPaginatorFactory : IMarketplaceCatalogPaginatorFactory
    {
        private readonly IAmazonMarketplaceCatalog client;

        internal MarketplaceCatalogPaginatorFactory(IAmazonMarketplaceCatalog client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChangeSets operation
        ///</summary>
        public IListChangeSetsPaginator ListChangeSets(ListChangeSetsRequest request) 
        {
            return new ListChangeSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntities operation
        ///</summary>
        public IListEntitiesPaginator ListEntities(ListEntitiesRequest request) 
        {
            return new ListEntitiesPaginator(this.client, request);
        }
    }
}