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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Paginators for the CleanRooms service
    ///</summary>
    public class CleanRoomsPaginatorFactory : ICleanRoomsPaginatorFactory
    {
        private readonly IAmazonCleanRooms client;

        internal CleanRoomsPaginatorFactory(IAmazonCleanRooms client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCollaborations operation
        ///</summary>
        public IListCollaborationsPaginator ListCollaborations(ListCollaborationsRequest request) 
        {
            return new ListCollaborationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredTableAssociations operation
        ///</summary>
        public IListConfiguredTableAssociationsPaginator ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request) 
        {
            return new ListConfiguredTableAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfiguredTables operation
        ///</summary>
        public IListConfiguredTablesPaginator ListConfiguredTables(ListConfiguredTablesRequest request) 
        {
            return new ListConfiguredTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberships operation
        ///</summary>
        public IListMembershipsPaginator ListMemberships(ListMembershipsRequest request) 
        {
            return new ListMembershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectedQueries operation
        ///</summary>
        public IListProtectedQueriesPaginator ListProtectedQueries(ListProtectedQueriesRequest request) 
        {
            return new ListProtectedQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }
    }
}