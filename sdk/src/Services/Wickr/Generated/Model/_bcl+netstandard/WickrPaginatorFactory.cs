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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Paginators for the Wickr service
    ///</summary>
    public partial class WickrPaginatorFactory : IWickrPaginatorFactory
    {
        private readonly IAmazonWickr client;

        internal WickrPaginatorFactory(IAmazonWickr client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBlockedGuestUsers operation
        ///</summary>
        public IListBlockedGuestUsersPaginator ListBlockedGuestUsers(ListBlockedGuestUsersRequest request) 
        {
            return new ListBlockedGuestUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBots operation
        ///</summary>
        public IListBotsPaginator ListBots(ListBotsRequest request) 
        {
            return new ListBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevicesForUser operation
        ///</summary>
        public IListDevicesForUserPaginator ListDevicesForUser(ListDevicesForUserRequest request) 
        {
            return new ListDevicesForUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGuestUsers operation
        ///</summary>
        public IListGuestUsersPaginator ListGuestUsers(ListGuestUsersRequest request) 
        {
            return new ListGuestUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        public IListNetworksPaginator ListNetworks(ListNetworksRequest request) 
        {
            return new ListNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityGroups operation
        ///</summary>
        public IListSecurityGroupsPaginator ListSecurityGroups(ListSecurityGroupsRequest request) 
        {
            return new ListSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityGroupUsers operation
        ///</summary>
        public IListSecurityGroupUsersPaginator ListSecurityGroupUsers(ListSecurityGroupUsersRequest request) 
        {
            return new ListSecurityGroupUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}