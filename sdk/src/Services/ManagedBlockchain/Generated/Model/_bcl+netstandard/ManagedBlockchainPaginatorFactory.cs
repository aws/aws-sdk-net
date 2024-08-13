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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Paginators for the ManagedBlockchain service
    ///</summary>
    public class ManagedBlockchainPaginatorFactory : IManagedBlockchainPaginatorFactory
    {
        private readonly IAmazonManagedBlockchain client;

        internal ManagedBlockchainPaginatorFactory(IAmazonManagedBlockchain client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccessors operation
        ///</summary>
        public IListAccessorsPaginator ListAccessors(ListAccessorsRequest request) 
        {
            return new ListAccessorsPaginator(this.client, request);
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
        /// Paginator for ListNetworks operation
        ///</summary>
        public IListNetworksPaginator ListNetworks(ListNetworksRequest request) 
        {
            return new ListNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        public IListNodesPaginator ListNodes(ListNodesRequest request) 
        {
            return new ListNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProposals operation
        ///</summary>
        public IListProposalsPaginator ListProposals(ListProposalsRequest request) 
        {
            return new ListProposalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProposalVotes operation
        ///</summary>
        public IListProposalVotesPaginator ListProposalVotes(ListProposalVotesRequest request) 
        {
            return new ListProposalVotesPaginator(this.client, request);
        }
    }
}