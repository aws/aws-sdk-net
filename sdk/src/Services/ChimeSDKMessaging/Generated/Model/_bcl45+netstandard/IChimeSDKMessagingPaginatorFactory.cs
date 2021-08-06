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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKMessaging service
    ///</summary>
    public interface IChimeSDKMessagingPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListChannelBans operation
        ///</summary>
        IListChannelBansPaginator ListChannelBans(ListChannelBansRequest request);

        /// <summary>
        /// Paginator for ListChannelMemberships operation
        ///</summary>
        IListChannelMembershipsPaginator ListChannelMemberships(ListChannelMembershipsRequest request);

        /// <summary>
        /// Paginator for ListChannelMembershipsForAppInstanceUser operation
        ///</summary>
        IListChannelMembershipsForAppInstanceUserPaginator ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request);

        /// <summary>
        /// Paginator for ListChannelMessages operation
        ///</summary>
        IListChannelMessagesPaginator ListChannelMessages(ListChannelMessagesRequest request);

        /// <summary>
        /// Paginator for ListChannelModerators operation
        ///</summary>
        IListChannelModeratorsPaginator ListChannelModerators(ListChannelModeratorsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListChannelsModeratedByAppInstanceUser operation
        ///</summary>
        IListChannelsModeratedByAppInstanceUserPaginator ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request);
    }
}