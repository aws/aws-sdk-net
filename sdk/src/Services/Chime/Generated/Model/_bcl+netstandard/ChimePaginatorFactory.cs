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

#pragma warning disable CS0612,CS0618
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
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
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
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        ///</summary>
        public ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request) 
        {
            return new SearchAvailablePhoneNumbersPaginator(this.client, request);
        }
    }
}