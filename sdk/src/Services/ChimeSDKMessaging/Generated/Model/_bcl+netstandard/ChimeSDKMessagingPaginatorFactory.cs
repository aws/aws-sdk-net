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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKMessaging service
    ///</summary>
    public class ChimeSDKMessagingPaginatorFactory : IChimeSDKMessagingPaginatorFactory
    {
        private readonly IAmazonChimeSDKMessaging client;

        internal ChimeSDKMessagingPaginatorFactory(IAmazonChimeSDKMessaging client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannelBans operation
        ///</summary>
        public IListChannelBansPaginator ListChannelBans(ListChannelBansRequest request) 
        {
            return new ListChannelBansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelFlows operation
        ///</summary>
        public IListChannelFlowsPaginator ListChannelFlows(ListChannelFlowsRequest request) 
        {
            return new ListChannelFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelMemberships operation
        ///</summary>
        public IListChannelMembershipsPaginator ListChannelMemberships(ListChannelMembershipsRequest request) 
        {
            return new ListChannelMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelMembershipsForAppInstanceUser operation
        ///</summary>
        public IListChannelMembershipsForAppInstanceUserPaginator ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request) 
        {
            return new ListChannelMembershipsForAppInstanceUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelMessages operation
        ///</summary>
        public IListChannelMessagesPaginator ListChannelMessages(ListChannelMessagesRequest request) 
        {
            return new ListChannelMessagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelModerators operation
        ///</summary>
        public IListChannelModeratorsPaginator ListChannelModerators(ListChannelModeratorsRequest request) 
        {
            return new ListChannelModeratorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelsAssociatedWithChannelFlow operation
        ///</summary>
        public IListChannelsAssociatedWithChannelFlowPaginator ListChannelsAssociatedWithChannelFlow(ListChannelsAssociatedWithChannelFlowRequest request) 
        {
            return new ListChannelsAssociatedWithChannelFlowPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelsModeratedByAppInstanceUser operation
        ///</summary>
        public IListChannelsModeratedByAppInstanceUserPaginator ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request) 
        {
            return new ListChannelsModeratedByAppInstanceUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubChannels operation
        ///</summary>
        public IListSubChannelsPaginator ListSubChannels(ListSubChannelsRequest request) 
        {
            return new ListSubChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchChannels operation
        ///</summary>
        public ISearchChannelsPaginator SearchChannels(SearchChannelsRequest request) 
        {
            return new SearchChannelsPaginator(this.client, request);
        }
    }
}