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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Paginators for the GlobalAccelerator service
    ///</summary>
    public interface IGlobalAcceleratorPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccelerators operation
        ///</summary>
        IListAcceleratorsPaginator ListAccelerators(ListAcceleratorsRequest request);

        /// <summary>
        /// Paginator for ListByoipCidrs operation
        ///</summary>
        IListByoipCidrsPaginator ListByoipCidrs(ListByoipCidrsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingAccelerators operation
        ///</summary>
        IListCustomRoutingAcceleratorsPaginator ListCustomRoutingAccelerators(ListCustomRoutingAcceleratorsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingEndpointGroups operation
        ///</summary>
        IListCustomRoutingEndpointGroupsPaginator ListCustomRoutingEndpointGroups(ListCustomRoutingEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingListeners operation
        ///</summary>
        IListCustomRoutingListenersPaginator ListCustomRoutingListeners(ListCustomRoutingListenersRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappings operation
        ///</summary>
        IListCustomRoutingPortMappingsPaginator ListCustomRoutingPortMappings(ListCustomRoutingPortMappingsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappingsByDestination operation
        ///</summary>
        IListCustomRoutingPortMappingsByDestinationPaginator ListCustomRoutingPortMappingsByDestination(ListCustomRoutingPortMappingsByDestinationRequest request);

        /// <summary>
        /// Paginator for ListEndpointGroups operation
        ///</summary>
        IListEndpointGroupsPaginator ListEndpointGroups(ListEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListListeners operation
        ///</summary>
        IListListenersPaginator ListListeners(ListListenersRequest request);
    }
}
#endif