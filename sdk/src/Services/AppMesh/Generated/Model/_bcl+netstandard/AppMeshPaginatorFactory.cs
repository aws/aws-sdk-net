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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Paginators for the AppMesh service
    ///</summary>
    public class AppMeshPaginatorFactory : IAppMeshPaginatorFactory
    {
        private readonly IAmazonAppMesh client;

        internal AppMeshPaginatorFactory(IAmazonAppMesh client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListGatewayRoutes operation
        ///</summary>
        public IListGatewayRoutesPaginator ListGatewayRoutes(ListGatewayRoutesRequest request) 
        {
            return new ListGatewayRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMeshes operation
        ///</summary>
        public IListMeshesPaginator ListMeshes(ListMeshesRequest request) 
        {
            return new ListMeshesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutes operation
        ///</summary>
        public IListRoutesPaginator ListRoutes(ListRoutesRequest request) 
        {
            return new ListRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualGateways operation
        ///</summary>
        public IListVirtualGatewaysPaginator ListVirtualGateways(ListVirtualGatewaysRequest request) 
        {
            return new ListVirtualGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualNodes operation
        ///</summary>
        public IListVirtualNodesPaginator ListVirtualNodes(ListVirtualNodesRequest request) 
        {
            return new ListVirtualNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualRouters operation
        ///</summary>
        public IListVirtualRoutersPaginator ListVirtualRouters(ListVirtualRoutersRequest request) 
        {
            return new ListVirtualRoutersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVirtualServices operation
        ///</summary>
        public IListVirtualServicesPaginator ListVirtualServices(ListVirtualServicesRequest request) 
        {
            return new ListVirtualServicesPaginator(this.client, request);
        }
    }
}