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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Paginators for the AppMesh service
    ///</summary>
    public interface IAppMeshPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListGatewayRoutes operation
        ///</summary>
        IListGatewayRoutesPaginator ListGatewayRoutes(ListGatewayRoutesRequest request);

        /// <summary>
        /// Paginator for ListMeshes operation
        ///</summary>
        IListMeshesPaginator ListMeshes(ListMeshesRequest request);

        /// <summary>
        /// Paginator for ListRoutes operation
        ///</summary>
        IListRoutesPaginator ListRoutes(ListRoutesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListVirtualGateways operation
        ///</summary>
        IListVirtualGatewaysPaginator ListVirtualGateways(ListVirtualGatewaysRequest request);

        /// <summary>
        /// Paginator for ListVirtualNodes operation
        ///</summary>
        IListVirtualNodesPaginator ListVirtualNodes(ListVirtualNodesRequest request);

        /// <summary>
        /// Paginator for ListVirtualRouters operation
        ///</summary>
        IListVirtualRoutersPaginator ListVirtualRouters(ListVirtualRoutersRequest request);

        /// <summary>
        /// Paginator for ListVirtualServices operation
        ///</summary>
        IListVirtualServicesPaginator ListVirtualServices(ListVirtualServicesRequest request);
    }
}