/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedBlockchain.Model;

namespace Amazon.ManagedBlockchain
{
    /// <summary>
    /// Interface for accessing ManagedBlockchain
    ///
    /// Amazon Managed Blockchain is a fully managed service for creating and managing blockchain
    /// networks using open source frameworks. Blockchain allows you to build applications
    /// where multiple parties can securely and transparently run transactions and share data
    /// without the need for a trusted, central authority. Currently, Managed Blockchain supports
    /// the Hyperledger Fabric open source framework.
    /// </summary>
    public partial interface IAmazonManagedBlockchain : IAmazonService, IDisposable
    {
                
        #region  CreateMember



        /// <summary>
        /// Creates a member within a Managed Blockchain network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateMember">REST API Reference for CreateMember Operation</seealso>
        Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetwork



        /// <summary>
        /// Creates a new blockchain network using Amazon Managed Blockchain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNode



        /// <summary>
        /// Creates a peer node in a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceAlreadyExistsException">
        /// A resource request is issued for a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNode">REST API Reference for CreateNode Operation</seealso>
        Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProposal



        /// <summary>
        /// Creates a proposal for a change to the network that other members of the network can
        /// vote on, for example, a proposal to add a new member to the network. Any member can
        /// create a proposal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateProposal">REST API Reference for CreateProposal Operation</seealso>
        Task<CreateProposalResponse> CreateProposalAsync(CreateProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMember



        /// <summary>
        /// Deletes a member. Deleting a member removes the member and all associated resources
        /// from the network. <code>DeleteMember</code> can only be called for a specified <code>MemberId</code>
        /// if the principal performing the action is associated with the AWS account that owns
        /// the member. In all other cases, the <code>DeleteMember</code> action is carried out
        /// as the result of an approved proposal to remove a member. If <code>MemberId</code>
        /// is the last member in a network specified by the last AWS account, the network is
        /// deleted also.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNode



        /// <summary>
        /// Deletes a peer node from a member that your AWS account owns. All data on the node
        /// is lost and cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but is not in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMember



        /// <summary>
        /// Returns detailed information about a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetMember">REST API Reference for GetMember Operation</seealso>
        Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNetwork



        /// <summary>
        /// Returns detailed information about a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNode



        /// <summary>
        /// Returns detailed information about a peer node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNode">REST API Reference for GetNode Operation</seealso>
        Task<GetNodeResponse> GetNodeAsync(GetNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProposal



        /// <summary>
        /// Returns detailed information about a proposal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetProposal">REST API Reference for GetProposal Operation</seealso>
        Task<GetProposalResponse> GetProposalAsync(GetProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvitations



        /// <summary>
        /// Returns a listing of all invitations made on the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceLimitExceededException">
        /// The maximum number of resources of that type already exist. Ensure the resources requested
        /// are within the boundaries of the service edition and your account limits.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMembers



        /// <summary>
        /// Returns a listing of the members in a network and properties of their configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNetworks



        /// <summary>
        /// Returns information about the networks in which the current AWS account has members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNodes



        /// <summary>
        /// Returns information about the nodes within a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProposals



        /// <summary>
        /// Returns a listing of proposals for the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProposals service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposals">REST API Reference for ListProposals Operation</seealso>
        Task<ListProposalsResponse> ListProposalsAsync(ListProposalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProposalVotes



        /// <summary>
        /// Returns the listing of votes for a specified proposal, including the value of each
        /// vote and the unique identifier of the member that cast the vote.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposalVotes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProposalVotes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposalVotes">REST API Reference for ListProposalVotes Operation</seealso>
        Task<ListProposalVotesResponse> ListProposalVotesAsync(ListProposalVotesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectInvitation



        /// <summary>
        /// Rejects an invitation to join a network. This action can be called by a principal
        /// in an AWS account that has received an invitation to create a member and join a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.IllegalActionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        Task<RejectInvitationResponse> RejectInvitationAsync(RejectInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VoteOnProposal



        /// <summary>
        /// Casts a vote for a specified <code>ProposalId</code> on behalf of a member. The member
        /// to vote as, specified by <code>VoterMemberId</code>, must be in the same AWS account
        /// as the principal that calls the action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VoteOnProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VoteOnProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.IllegalActionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource does not exist on the network. It may have been deleted or referenced
        /// inaccurately.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation could not be performed because a service is throttling requests.
        /// The most common source of throttling errors is launching EC2 instances such that your
        /// service limit for EC2 instances is exceeded. Request a limit increase or delete unused
        /// resources if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/VoteOnProposal">REST API Reference for VoteOnProposal Operation</seealso>
        Task<VoteOnProposalResponse> VoteOnProposalAsync(VoteOnProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}