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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Paginators for the CognitoIdentityProvider service
    /// </summary>
    public interface ICognitoIdentityProviderPaginatorFactory
    {
        /// <summary>
        /// Paginator for AdminListGroupsForUser operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IAdminListGroupsForUserPaginator AdminListGroupsForUser(AdminListGroupsForUserRequest request);

        /// <summary>
        /// Paginator for AdminListUserAuthEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IAdminListUserAuthEventsPaginator AdminListUserAuthEvents(AdminListUserAuthEventsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIdentityProviders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIdentityProvidersPaginator ListIdentityProviders(ListIdentityProvidersRequest request);

        /// <summary>
        /// Paginator for ListResourceServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceServersPaginator ListResourceServers(ListResourceServersRequest request);

        /// <summary>
        /// Paginator for ListUserPoolClients operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserPoolClientsPaginator ListUserPoolClients(ListUserPoolClientsRequest request);

        /// <summary>
        /// Paginator for ListUserPools operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUserPoolsPaginator ListUserPools(ListUserPoolsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["PaginationToken"], LimitKey = "Limit", OutputToken = ["PaginationToken"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListUsersInGroup operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "Limit", OutputToken = ["NextToken"])]
        IListUsersInGroupPaginator ListUsersInGroup(ListUsersInGroupRequest request);
    }
}
