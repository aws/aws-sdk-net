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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Paginators for the ManagedBlockchain service
    ///</summary>
    public interface IManagedBlockchainPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccessors operation
        ///</summary>
        IListAccessorsPaginator ListAccessors(ListAccessorsRequest request);

        /// <summary>
        /// Paginator for ListInvitations operation
        ///</summary>
        IListInvitationsPaginator ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Paginator for ListMembers operation
        ///</summary>
        IListMembersPaginator ListMembers(ListMembersRequest request);

        /// <summary>
        /// Paginator for ListNetworks operation
        ///</summary>
        IListNetworksPaginator ListNetworks(ListNetworksRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListProposals operation
        ///</summary>
        IListProposalsPaginator ListProposals(ListProposalsRequest request);

        /// <summary>
        /// Paginator for ListProposalVotes operation
        ///</summary>
        IListProposalVotesPaginator ListProposalVotes(ListProposalVotesRequest request);
    }
}