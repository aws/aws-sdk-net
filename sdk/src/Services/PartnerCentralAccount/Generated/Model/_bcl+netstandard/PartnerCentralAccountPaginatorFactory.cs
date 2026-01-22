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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Paginators for the PartnerCentralAccount service
    ///</summary>
    public partial class PartnerCentralAccountPaginatorFactory : IPartnerCentralAccountPaginatorFactory
    {
        private readonly IAmazonPartnerCentralAccount client;

        internal PartnerCentralAccountPaginatorFactory(IAmazonPartnerCentralAccount client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListConnectionInvitations operation
        ///</summary>
        public IListConnectionInvitationsPaginator ListConnectionInvitations(ListConnectionInvitationsRequest request) 
        {
            return new ListConnectionInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        public IListConnectionsPaginator ListConnections(ListConnectionsRequest request) 
        {
            return new ListConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPartners operation
        ///</summary>
        public IListPartnersPaginator ListPartners(ListPartnersRequest request) 
        {
            return new ListPartnersPaginator(this.client, request);
        }
    }
}