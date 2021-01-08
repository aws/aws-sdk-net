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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Paginators for the Chime service
    ///</summary>
    public interface IChimePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccounts operation
        ///</summary>
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceAdmins operation
        ///</summary>
        IListAppInstanceAdminsPaginator ListAppInstanceAdmins(ListAppInstanceAdminsRequest request);

        /// <summary>
        /// Paginator for ListAppInstances operation
        ///</summary>
        IListAppInstancesPaginator ListAppInstances(ListAppInstancesRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceUsers operation
        ///</summary>
        IListAppInstanceUsersPaginator ListAppInstanceUsers(ListAppInstanceUsersRequest request);

        /// <summary>
        /// Paginator for ListAttendees operation
        ///</summary>
        IListAttendeesPaginator ListAttendees(ListAttendeesRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        IListBotsPaginator ListBots(ListBotsRequest request);

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

        /// <summary>
        /// Paginator for ListMeetings operation
        ///</summary>
        IListMeetingsPaginator ListMeetings(ListMeetingsRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        ///</summary>
        IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListProxySessions operation
        ///</summary>
        IListProxySessionsPaginator ListProxySessions(ListProxySessionsRequest request);

        /// <summary>
        /// Paginator for ListRoomMemberships operation
        ///</summary>
        IListRoomMembershipsPaginator ListRoomMemberships(ListRoomMembershipsRequest request);

        /// <summary>
        /// Paginator for ListRooms operation
        ///</summary>
        IListRoomsPaginator ListRooms(ListRoomsRequest request);

        /// <summary>
        /// Paginator for ListSipMediaApplications operation
        ///</summary>
        IListSipMediaApplicationsPaginator ListSipMediaApplications(ListSipMediaApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSipRules operation
        ///</summary>
        IListSipRulesPaginator ListSipRules(ListSipRulesRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectorGroups operation
        ///</summary>
        IListVoiceConnectorGroupsPaginator ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request);

        /// <summary>
        /// Paginator for ListVoiceConnectors operation
        ///</summary>
        IListVoiceConnectorsPaginator ListVoiceConnectors(ListVoiceConnectorsRequest request);
    }
}
#endif