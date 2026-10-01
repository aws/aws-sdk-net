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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Paginators for the Chime service
    /// </summary>
    public interface IChimePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListBots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBotsPaginator ListBots(ListBotsRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumberOrders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumberOrdersPaginator ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPhoneNumbersPaginator ListPhoneNumbers(ListPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListRoomMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoomMembershipsPaginator ListRoomMemberships(ListRoomMembershipsRequest request);

        /// <summary>
        /// Paginator for ListRooms operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRoomsPaginator ListRooms(ListRoomsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for SearchAvailablePhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchAvailablePhoneNumbersPaginator SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request);
    }
}
