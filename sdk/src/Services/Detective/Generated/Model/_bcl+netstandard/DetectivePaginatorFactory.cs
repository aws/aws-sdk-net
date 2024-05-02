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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Paginators for the Detective service
    ///</summary>
    public class DetectivePaginatorFactory : IDetectivePaginatorFactory
    {
        private readonly IAmazonDetective client;

        internal DetectivePaginatorFactory(IAmazonDetective client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDatasourcePackages operation
        ///</summary>
        public IListDatasourcePackagesPaginator ListDatasourcePackages(ListDatasourcePackagesRequest request) 
        {
            return new ListDatasourcePackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGraphs operation
        ///</summary>
        public IListGraphsPaginator ListGraphs(ListGraphsRequest request) 
        {
            return new ListGraphsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        public IListInvitationsPaginator ListInvitations(ListInvitationsRequest request) 
        {
            return new ListInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        public IListMembersPaginator ListMembers(ListMembersRequest request) 
        {
            return new ListMembersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationAdminAccounts operation
        ///</summary>
        public IListOrganizationAdminAccountsPaginator ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request) 
        {
            return new ListOrganizationAdminAccountsPaginator(this.client, request);
        }
    }
}