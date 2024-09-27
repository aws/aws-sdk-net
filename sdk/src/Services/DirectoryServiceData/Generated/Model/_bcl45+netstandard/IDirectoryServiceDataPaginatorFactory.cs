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

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Paginators for the DirectoryServiceData service
    ///</summary>
    public interface IDirectoryServiceDataPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListGroupMembers operation
        ///</summary>
        IListGroupMembersPaginator ListGroupMembers(ListGroupMembersRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupsForMember operation
        ///</summary>
        IListGroupsForMemberPaginator ListGroupsForMember(ListGroupsForMemberRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for SearchGroups operation
        ///</summary>
        ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request);

        /// <summary>
        /// Paginator for SearchUsers operation
        ///</summary>
        ISearchUsersPaginator SearchUsers(SearchUsersRequest request);
    }
}