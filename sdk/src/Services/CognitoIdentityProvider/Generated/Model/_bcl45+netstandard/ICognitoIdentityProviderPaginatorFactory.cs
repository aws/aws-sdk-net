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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Paginators for the CognitoIdentityProvider service
    ///</summary>
    public interface ICognitoIdentityProviderPaginatorFactory
    {

        /// <summary>
        /// Paginator for AdminListGroupsForUser operation
        ///</summary>
        IAdminListGroupsForUserPaginator AdminListGroupsForUser(AdminListGroupsForUserRequest request);

        /// <summary>
        /// Paginator for AdminListUserAuthEvents operation
        ///</summary>
        IAdminListUserAuthEventsPaginator AdminListUserAuthEvents(AdminListUserAuthEventsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        ///</summary>
        IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Paginator for ListResourceServers operation
        ///</summary>
        IListResourceServersPaginator ListResourceServers(ListResourceServersRequest request);

        /// <summary>
        /// Paginator for ListUserPoolClients operation
        ///</summary>
        IListUserPoolClientsPaginator ListUserPoolClients(ListUserPoolClientsRequest request);

        /// <summary>
        /// Paginator for ListUserPools operation
        ///</summary>
        IListUserPoolsPaginator ListUserPools(ListUserPoolsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListUsersInGroup operation
        ///</summary>
        IListUsersInGroupPaginator ListUsersInGroup(ListUsersInGroupRequest request);
    }
}
#endif