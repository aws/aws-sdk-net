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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Paginators for the RTBFabric service
    ///</summary>
    public partial class RTBFabricPaginatorFactory : IRTBFabricPaginatorFactory
    {
        private readonly IAmazonRTBFabric client;

        internal RTBFabricPaginatorFactory(IAmazonRTBFabric client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListLinks operation
        ///</summary>
        public IListLinksPaginator ListLinks(ListLinksRequest request) 
        {
            return new ListLinksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRequesterGateways operation
        ///</summary>
        public IListRequesterGatewaysPaginator ListRequesterGateways(ListRequesterGatewaysRequest request) 
        {
            return new ListRequesterGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResponderGateways operation
        ///</summary>
        public IListResponderGatewaysPaginator ListResponderGateways(ListResponderGatewaysRequest request) 
        {
            return new ListResponderGatewaysPaginator(this.client, request);
        }
    }
}