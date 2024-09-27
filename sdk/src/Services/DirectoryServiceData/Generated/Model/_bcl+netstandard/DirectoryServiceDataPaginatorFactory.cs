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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Paginators for the DirectoryServiceData service
    ///</summary>
    public class DirectoryServiceDataPaginatorFactory : IDirectoryServiceDataPaginatorFactory
    {
        private readonly IAmazonDirectoryServiceData client;

        internal DirectoryServiceDataPaginatorFactory(IAmazonDirectoryServiceData client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListGroupMembers operation
        ///</summary>
        public IListGroupMembersPaginator ListGroupMembers(ListGroupMembersRequest request) 
        {
            return new ListGroupMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupsForMember operation
        ///</summary>
        public IListGroupsForMemberPaginator ListGroupsForMember(ListGroupsForMemberRequest request) 
        {
            return new ListGroupsForMemberPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchGroups operation
        ///</summary>
        public ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request) 
        {
            return new SearchGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        public ISearchUsersPaginator SearchUsers(SearchUsersRequest request) 
        {
            return new SearchUsersPaginator(this.client, request);
        }
    }
}