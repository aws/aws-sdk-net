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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Paginators for the Chime service
    ///</summary>
    public class ChimePaginatorFactory : IChimePaginatorFactory
    {
        private readonly IAmazonChime client;

        internal ChimePaginatorFactory(IAmazonChime client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccounts operation
        ///</summary>
        public IListAccountsPaginator ListAccounts(ListAccountsRequest request) 
        {
            return new ListAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstanceAdmins operation
        ///</summary>
        public IListAppInstanceAdminsPaginator ListAppInstanceAdmins(ListAppInstanceAdminsRequest request) 
        {
            return new ListAppInstanceAdminsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstances operation
        ///</summary>
        public IListAppInstancesPaginator ListAppInstances(ListAppInstancesRequest request) 
        {
            return new ListAppInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstanceUsers operation
        ///</summary>
        public IListAppInstanceUsersPaginator ListAppInstanceUsers(ListAppInstanceUsersRequest request) 
        {
            return new ListAppInstanceUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttendees operation
        ///</summary>
        public IListAttendeesPaginator ListAttendees(ListAttendeesRequest request) 
        {
            return new ListAttendeesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelBans operation
        ///</summary>
        public IListChannelBansPaginator ListChannelBans(ListChannelBansRequest request) 
        {
            return new ListChannelBansPaginator(this.client, request);
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
        /// Paginator for ListChannelsModeratedByAppInstanceUser operation
        ///</summary>
        public IListChannelsModeratedByAppInstanceUserPaginator ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request) 
        {
            return new ListChannelsModeratedByAppInstanceUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMeetings operation
        ///</summary>
        public IListMeetingsPaginator ListMeetings(ListMeetingsRequest request) 
        {
            return new ListMeetingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        ///</summary>
        public IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request) 
        {
            return new ListPhoneNumberOrdersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        ///</summary>
        public IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request) 
        {
            return new ListPhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProxySessions operation
        ///</summary>
        public IListProxySessionsPaginator ListProxySessions(ListProxySessionsRequest request) 
        {
            return new ListProxySessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoomMemberships operation
        ///</summary>
        public IListRoomMembershipsPaginator ListRoomMemberships(ListRoomMembershipsRequest request) 
        {
            return new ListRoomMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRooms operation
        ///</summary>
        public IListRoomsPaginator ListRooms(ListRoomsRequest request) 
        {
            return new ListRoomsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSipMediaApplications operation
        ///</summary>
        public IListSipMediaApplicationsPaginator ListSipMediaApplications(ListSipMediaApplicationsRequest request) 
        {
            return new ListSipMediaApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSipRules operation
        ///</summary>
        public IListSipRulesPaginator ListSipRules(ListSipRulesRequest request) 
        {
            return new ListSipRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceConnectorGroups operation
        ///</summary>
        public IListVoiceConnectorGroupsPaginator ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request) 
        {
            return new ListVoiceConnectorGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVoiceConnectors operation
        ///</summary>
        public IListVoiceConnectorsPaginator ListVoiceConnectors(ListVoiceConnectorsRequest request) 
        {
            return new ListVoiceConnectorsPaginator(this.client, request);
        }
    }
}
#endif