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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Paginators for the IdentityStore service
    ///</summary>
    public class IdentityStorePaginatorFactory : IIdentityStorePaginatorFactory
    {
        private readonly IAmazonIdentityStore client;

        internal IdentityStorePaginatorFactory(IAmazonIdentityStore client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListGroupMemberships operation
        ///</summary>
        public IListGroupMembershipsPaginator ListGroupMemberships(ListGroupMembershipsRequest request) 
        {
            return new ListGroupMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupMembershipsForMember operation
        ///</summary>
        public IListGroupMembershipsForMemberPaginator ListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request) 
        {
            return new ListGroupMembershipsForMemberPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
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