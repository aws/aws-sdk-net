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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Paginators for the EventBridgeV2 service
    ///</summary>
    public class EventBridgeV2PaginatorFactory : IEventBridgeV2PaginatorFactory
    {
        private readonly IAmazonEventBridgeV2 client;

        internal EventBridgeV2PaginatorFactory(IAmazonEventBridgeV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEventBuses operation
        ///</summary>
        public IListEventBusesPaginator ListEventBuses(ListEventBusesRequest request) 
        {
            return new ListEventBusesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventSources operation
        ///</summary>
        public IListEventSourcesPaginator ListEventSources(ListEventSourcesRequest request) 
        {
            return new ListEventSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcePolicies operation
        ///</summary>
        public IListResourcePoliciesPaginator ListResourcePolicies(ListResourcePoliciesRequest request) 
        {
            return new ListResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscribers operation
        ///</summary>
        public IListSubscribersPaginator ListSubscribers(ListSubscribersRequest request) 
        {
            return new ListSubscribersPaginator(this.client, request);
        }
    }
}