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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Paginators for the PartnerCentralChannel service
    ///</summary>
    public class PartnerCentralChannelPaginatorFactory : IPartnerCentralChannelPaginatorFactory
    {
        private readonly IAmazonPartnerCentralChannel client;

        internal PartnerCentralChannelPaginatorFactory(IAmazonPartnerCentralChannel client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannelHandshakes operation
        ///</summary>
        public IListChannelHandshakesPaginator ListChannelHandshakes(ListChannelHandshakesRequest request) 
        {
            return new ListChannelHandshakesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProgramManagementAccounts operation
        ///</summary>
        public IListProgramManagementAccountsPaginator ListProgramManagementAccounts(ListProgramManagementAccountsRequest request) 
        {
            return new ListProgramManagementAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRelationships operation
        ///</summary>
        public IListRelationshipsPaginator ListRelationships(ListRelationshipsRequest request) 
        {
            return new ListRelationshipsPaginator(this.client, request);
        }
    }
}