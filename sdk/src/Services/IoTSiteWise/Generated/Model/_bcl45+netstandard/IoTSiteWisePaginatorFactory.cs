#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Paginators for the IoTSiteWise service
    ///</summary>
    public class IoTSiteWisePaginatorFactory : IIoTSiteWisePaginatorFactory
    {
        private readonly IAmazonIoTSiteWise client;

        internal IoTSiteWisePaginatorFactory(IAmazonIoTSiteWise client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetAssetPropertyAggregates operation
        ///</summary>
        public IGetAssetPropertyAggregatesPaginator GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request) 
        {
            return new GetAssetPropertyAggregatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAssetPropertyValueHistory operation
        ///</summary>
        public IGetAssetPropertyValueHistoryPaginator GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request) 
        {
            return new GetAssetPropertyValueHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        public IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request) 
        {
            return new ListAccessPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetModels operation
        ///</summary>
        public IListAssetModelsPaginator ListAssetModels(ListAssetModelsRequest request) 
        {
            return new ListAssetModelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssetRelationships operation
        ///</summary>
        public IListAssetRelationshipsPaginator ListAssetRelationships(ListAssetRelationshipsRequest request) 
        {
            return new ListAssetRelationshipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        public IListAssetsPaginator ListAssets(ListAssetsRequest request) 
        {
            return new ListAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedAssets operation
        ///</summary>
        public IListAssociatedAssetsPaginator ListAssociatedAssets(ListAssociatedAssetsRequest request) 
        {
            return new ListAssociatedAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        public IListDashboardsPaginator ListDashboards(ListDashboardsRequest request) 
        {
            return new ListDashboardsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        public IListGatewaysPaginator ListGateways(ListGatewaysRequest request) 
        {
            return new ListGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortals operation
        ///</summary>
        public IListPortalsPaginator ListPortals(ListPortalsRequest request) 
        {
            return new ListPortalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjectAssets operation
        ///</summary>
        public IListProjectAssetsPaginator ListProjectAssets(ListProjectAssetsRequest request) 
        {
            return new ListProjectAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }
    }
}
#endif