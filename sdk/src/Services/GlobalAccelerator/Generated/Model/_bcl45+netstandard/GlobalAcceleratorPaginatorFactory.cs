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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Paginators for the GlobalAccelerator service
    ///</summary>
    public class GlobalAcceleratorPaginatorFactory : IGlobalAcceleratorPaginatorFactory
    {
        private readonly IAmazonGlobalAccelerator client;

        internal GlobalAcceleratorPaginatorFactory(IAmazonGlobalAccelerator client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccelerators operation
        ///</summary>
        public IListAcceleratorsPaginator ListAccelerators(ListAcceleratorsRequest request) 
        {
            return new ListAcceleratorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListByoipCidrs operation
        ///</summary>
        public IListByoipCidrsPaginator ListByoipCidrs(ListByoipCidrsRequest request) 
        {
            return new ListByoipCidrsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCrossAccountAttachments operation
        ///</summary>
        public IListCrossAccountAttachmentsPaginator ListCrossAccountAttachments(ListCrossAccountAttachmentsRequest request) 
        {
            return new ListCrossAccountAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCrossAccountResources operation
        ///</summary>
        public IListCrossAccountResourcesPaginator ListCrossAccountResources(ListCrossAccountResourcesRequest request) 
        {
            return new ListCrossAccountResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomRoutingAccelerators operation
        ///</summary>
        public IListCustomRoutingAcceleratorsPaginator ListCustomRoutingAccelerators(ListCustomRoutingAcceleratorsRequest request) 
        {
            return new ListCustomRoutingAcceleratorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomRoutingEndpointGroups operation
        ///</summary>
        public IListCustomRoutingEndpointGroupsPaginator ListCustomRoutingEndpointGroups(ListCustomRoutingEndpointGroupsRequest request) 
        {
            return new ListCustomRoutingEndpointGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomRoutingListeners operation
        ///</summary>
        public IListCustomRoutingListenersPaginator ListCustomRoutingListeners(ListCustomRoutingListenersRequest request) 
        {
            return new ListCustomRoutingListenersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappings operation
        ///</summary>
        public IListCustomRoutingPortMappingsPaginator ListCustomRoutingPortMappings(ListCustomRoutingPortMappingsRequest request) 
        {
            return new ListCustomRoutingPortMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappingsByDestination operation
        ///</summary>
        public IListCustomRoutingPortMappingsByDestinationPaginator ListCustomRoutingPortMappingsByDestination(ListCustomRoutingPortMappingsByDestinationRequest request) 
        {
            return new ListCustomRoutingPortMappingsByDestinationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEndpointGroups operation
        ///</summary>
        public IListEndpointGroupsPaginator ListEndpointGroups(ListEndpointGroupsRequest request) 
        {
            return new ListEndpointGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListListeners operation
        ///</summary>
        public IListListenersPaginator ListListeners(ListListenersRequest request) 
        {
            return new ListListenersPaginator(this.client, request);
        }
    }
}