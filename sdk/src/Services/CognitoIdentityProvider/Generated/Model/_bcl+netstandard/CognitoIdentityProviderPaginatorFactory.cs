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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Paginators for the CognitoIdentityProvider service
    ///</summary>
    public class CognitoIdentityProviderPaginatorFactory : ICognitoIdentityProviderPaginatorFactory
    {
        private readonly IAmazonCognitoIdentityProvider client;

        internal CognitoIdentityProviderPaginatorFactory(IAmazonCognitoIdentityProvider client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for AdminListGroupsForUser operation
        ///</summary>
        public IAdminListGroupsForUserPaginator AdminListGroupsForUser(AdminListGroupsForUserRequest request) 
        {
            return new AdminListGroupsForUserPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for AdminListUserAuthEvents operation
        ///</summary>
        public IAdminListUserAuthEventsPaginator AdminListUserAuthEvents(AdminListUserAuthEventsRequest request) 
        {
            return new AdminListUserAuthEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        public IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request) 
        {
            return new ListIdentityProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceServers operation
        ///</summary>
        public IListResourceServersPaginator ListResourceServers(ListResourceServersRequest request) 
        {
            return new ListResourceServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserPoolClients operation
        ///</summary>
        public IListUserPoolClientsPaginator ListUserPoolClients(ListUserPoolClientsRequest request) 
        {
            return new ListUserPoolClientsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUserPools operation
        ///</summary>
        public IListUserPoolsPaginator ListUserPools(ListUserPoolsRequest request) 
        {
            return new ListUserPoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsersInGroup operation
        ///</summary>
        public IListUsersInGroupPaginator ListUsersInGroup(ListUsersInGroupRequest request) 
        {
            return new ListUsersInGroupPaginator(this.client, request);
        }
    }
}