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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAcceleratorsPaginator ListAccelerators(ListAcceleratorsRequest request);

        /// <summary>
        /// Paginator for ListByoipCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListByoipCidrsPaginator ListByoipCidrs(ListByoipCidrsRequest request);

        /// <summary>
        /// Paginator for ListCrossAccountAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCrossAccountAttachmentsPaginator ListCrossAccountAttachments(ListCrossAccountAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListCrossAccountResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCrossAccountResourcesPaginator ListCrossAccountResources(ListCrossAccountResourcesRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingAccelerators operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomRoutingAcceleratorsPaginator ListCustomRoutingAccelerators(ListCustomRoutingAcceleratorsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingEndpointGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomRoutingEndpointGroupsPaginator ListCustomRoutingEndpointGroups(ListCustomRoutingEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingListeners operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomRoutingListenersPaginator ListCustomRoutingListeners(ListCustomRoutingListenersRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomRoutingPortMappingsPaginator ListCustomRoutingPortMappings(ListCustomRoutingPortMappingsRequest request);

        /// <summary>
        /// Paginator for ListCustomRoutingPortMappingsByDestination operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomRoutingPortMappingsByDestinationPaginator ListCustomRoutingPortMappingsByDestination(ListCustomRoutingPortMappingsByDestinationRequest request);

        /// <summary>
        /// Paginator for ListEndpointGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEndpointGroupsPaginator ListEndpointGroups(ListEndpointGroupsRequest request);

        /// <summary>
        /// Paginator for ListListeners operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListListenersPaginator ListListeners(ListListenersRequest request);
    }
}