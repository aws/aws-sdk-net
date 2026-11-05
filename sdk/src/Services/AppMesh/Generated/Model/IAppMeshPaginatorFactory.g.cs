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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Paginators for the AppMesh service
    /// </summary>
    public interface IAppMeshPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListGatewayRoutes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListGatewayRoutesPaginator ListGatewayRoutes(ListGatewayRoutesRequest request);

        /// <summary>
        /// Paginator for ListMeshes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListMeshesPaginator ListMeshes(ListMeshesRequest request);

        /// <summary>
        /// Paginator for ListRoutes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListRoutesPaginator ListRoutes(ListRoutesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListVirtualGateways operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListVirtualGatewaysPaginator ListVirtualGateways(ListVirtualGatewaysRequest request);

        /// <summary>
        /// Paginator for ListVirtualNodes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListVirtualNodesPaginator ListVirtualNodes(ListVirtualNodesRequest request);

        /// <summary>
        /// Paginator for ListVirtualRouters operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListVirtualRoutersPaginator ListVirtualRouters(ListVirtualRoutersRequest request);

        /// <summary>
        /// Paginator for ListVirtualServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListVirtualServicesPaginator ListVirtualServices(ListVirtualServicesRequest request);
    }
}
