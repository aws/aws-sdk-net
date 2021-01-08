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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Paginators for the RAM service
    ///</summary>
    public class RAMPaginatorFactory : IRAMPaginatorFactory
    {
        private readonly IAmazonRAM client;

        internal RAMPaginatorFactory(IAmazonRAM client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        public IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request) 
        {
            return new GetResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceShareAssociations operation
        ///</summary>
        public IGetResourceShareAssociationsPaginator GetResourceShareAssociations(GetResourceShareAssociationsRequest request) 
        {
            return new GetResourceShareAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceShareInvitations operation
        ///</summary>
        public IGetResourceShareInvitationsPaginator GetResourceShareInvitations(GetResourceShareInvitationsRequest request) 
        {
            return new GetResourceShareInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetResourceShares operation
        ///</summary>
        public IGetResourceSharesPaginator GetResourceShares(GetResourceSharesRequest request) 
        {
            return new GetResourceSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPendingInvitationResources operation
        ///</summary>
        public IListPendingInvitationResourcesPaginator ListPendingInvitationResources(ListPendingInvitationResourcesRequest request) 
        {
            return new ListPendingInvitationResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrincipals operation
        ///</summary>
        public IListPrincipalsPaginator ListPrincipals(ListPrincipalsRequest request) 
        {
            return new ListPrincipalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }
    }
}
#endif