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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedBlockchain.Model;

#pragma warning disable CS1570
namespace Amazon.ManagedBlockchain
{
    /// <summary>
    /// <para>Interface for accessing ManagedBlockchain</para>
    ///
    /// Amazon Managed Blockchain is a fully managed service for creating and managing blockchain
    /// networks using open-source frameworks. Blockchain allows you to build applications
    /// where multiple parties can securely and transparently run transactions and share data
    /// without the need for a trusted, central authority.
    /// 
    ///  
    /// <para>
    /// Managed Blockchain supports the Hyperledger Fabric and Ethereum open-source frameworks.
    /// Because of fundamental differences between the frameworks, some API actions or data
    /// types may only apply in the context of one framework and not the other. For example,
    /// actions related to Hyperledger Fabric network members such as <c>CreateMember</c>
    /// and <c>DeleteMember</c> don't apply to Ethereum.
    /// </para>
    ///  
    /// <para>
    /// The description for each action indicates the framework or frameworks to which it
    /// applies. Data types and properties that apply only in the context of a particular
    /// framework are similarly indicated.
    /// </para>
    /// </summary>
    public partial interface IAmazonManagedBlockchain : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedBlockchainPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAccessor



        /// <summary>
        /// Creates a new accessor for use with Amazon Managed Blockchain service that supports
        /// token based access. The accessor contains information required for token based access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessor service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateAccessor">REST API Reference for CreateAccessor Operation</seealso>
        Task<CreateAccessorResponse> CreateAccessorAsync(CreateAccessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMember



        /// <summary>
        /// Creates a member within a Managed Blockchain network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateMember">REST API Reference for CreateMember Operation</seealso>
        Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNetwork



        /// <summary>
        /// Creates a new blockchain network using Amazon Managed Blockchain.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNode



        /// <summary>
        /// Creates a node on the specified blockchain network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateNode">REST API Reference for CreateNode Operation</seealso>
        Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProposal



        /// <summary>
        /// Creates a proposal for a change to the network that other members of the network can
        /// vote on, for example, a proposal to add a new member to the network. Any member can
        /// create a proposal.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/CreateProposal">REST API Reference for CreateProposal Operation</seealso>
        Task<CreateProposalResponse> CreateProposalAsync(CreateProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessor



        /// <summary>
        /// Deletes an accessor that your Amazon Web Services account owns. An accessor object
        /// is a container that has the information required for token based access to your Ethereum
        /// nodes including, the <c>BILLING_TOKEN</c>. After an accessor is deleted, the status
        /// of the accessor changes from <c>AVAILABLE</c> to <c>PENDING_DELETION</c>. An accessor
        /// in the <c>PENDING_DELETION</c> state can’t be used for new WebSocket requests or HTTP
        /// requests. However, WebSocket connections that were initiated while the accessor was
        /// in the <c>AVAILABLE</c> state remain open until they expire (up to 2 hours).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessor service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteAccessor">REST API Reference for DeleteAccessor Operation</seealso>
        Task<DeleteAccessorResponse> DeleteAccessorAsync(DeleteAccessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMember



        /// <summary>
        /// Deletes a member. Deleting a member removes the member and all associated resources
        /// from the network. <c>DeleteMember</c> can only be called for a specified <c>MemberId</c>
        /// if the principal performing the action is associated with the Amazon Web Services
        /// account that owns the member. In all other cases, the <c>DeleteMember</c> action is
        /// carried out as the result of an approved proposal to remove a member. If <c>MemberId</c>
        /// is the last member in a network specified by the last Amazon Web Services account,
        /// the network is deleted also.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNode



        /// <summary>
        /// Deletes a node that your Amazon Web Services account owns. All data on the node is
        /// lost and cannot be recovered.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessor



        /// <summary>
        /// Returns detailed information about an accessor. An accessor object is a container
        /// that has the information required for token based access to your Ethereum nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessor service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetAccessor">REST API Reference for GetAccessor Operation</seealso>
        Task<GetAccessorResponse> GetAccessorAsync(GetAccessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMember



        /// <summary>
        /// Returns detailed information about a member.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetMember">REST API Reference for GetMember Operation</seealso>
        Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNetwork



        /// <summary>
        /// Returns detailed information about a network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNode



        /// <summary>
        /// Returns detailed information about a node.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetNode">REST API Reference for GetNode Operation</seealso>
        Task<GetNodeResponse> GetNodeAsync(GetNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProposal



        /// <summary>
        /// Returns detailed information about a proposal.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/GetProposal">REST API Reference for GetProposal Operation</seealso>
        Task<GetProposalResponse> GetProposalAsync(GetProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessors



        /// <summary>
        /// Returns a list of the accessors and their properties. Accessor objects are containers
        /// that have the information required for token based access to your Ethereum nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessors service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListAccessors">REST API Reference for ListAccessors Operation</seealso>
        Task<ListAccessorsResponse> ListAccessorsAsync(ListAccessorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvitations



        /// <summary>
        /// Returns a list of all invitations for the current Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMembers



        /// <summary>
        /// Returns a list of the members in a network and properties of their configurations.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNetworks



        /// <summary>
        /// Returns information about the networks in which the current Amazon Web Services account
        /// participates.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNodes



        /// <summary>
        /// Returns information about the nodes within a network.
        /// 
        ///  
        /// <para>
        /// Applies to Hyperledger Fabric and Ethereum.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProposals



        /// <summary>
        /// Returns a list of proposals for the network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProposals service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposals">REST API Reference for ListProposals Operation</seealso>
        Task<ListProposalsResponse> ListProposalsAsync(ListProposalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProposalVotes



        /// <summary>
        /// Returns the list of votes for a specified proposal, including the value of each vote
        /// and the unique identifier of the member that cast the vote.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProposalVotes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProposalVotes service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListProposalVotes">REST API Reference for ListProposalVotes Operation</seealso>
        Task<ListProposalVotesResponse> ListProposalVotesAsync(ListProposalVotesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for the specified resource. Each tag consists of a key and
        /// optional value.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectInvitation



        /// <summary>
        /// Rejects an invitation to join a network. This action can be called by a principal
        /// in an Amazon Web Services account that has received an invitation to create a member
        /// and join a network.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        Task<RejectInvitationResponse> RejectInvitationAsync(RejectInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or overwrites the specified tags for the specified Amazon Managed Blockchain
        /// resource. Each tag consists of a key and optional value.
        /// 
        ///  
        /// <para>
        /// When you specify a tag key that already exists, the tag value is overwritten with
        /// the new value. Use <c>UntagResource</c> to remove tag keys.
        /// </para>
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// your request fails and returns an error.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the Amazon Managed Blockchain resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotReadyException">
        /// The requested resource exists but isn't in a status that can complete the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMember



        /// <summary>
        /// Updates a member configuration with new parameters.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMember service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateMember">REST API Reference for UpdateMember Operation</seealso>
        Task<UpdateMemberResponse> UpdateMemberAsync(UpdateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNode



        /// <summary>
        /// Updates a node configuration with new parameters.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNode service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InternalServiceErrorException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.InvalidRequestException">
        /// The action or operation requested is invalid. Verify that the action is typed correctly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ResourceNotFoundException">
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        Task<UpdateNodeResponse> UpdateNodeAsync(UpdateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VoteOnProposal



        /// <summary>
        /// Casts a vote for a specified <c>ProposalId</c> on behalf of a member. The member to
        /// vote as, specified by <c>VoterMemberId</c>, must be in the same Amazon Web Services
        /// account as the principal that calls the action.
        /// 
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VoteOnProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VoteOnProposal service method, as returned by ManagedBlockchain.</returns>
        /// <exception cref="Amazon.ManagedBlockchain.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
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
        /// A requested resource doesn't exist. It may have been deleted or referenced incorrectly.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchain.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is creating resources that exceed your
        /// service limit for this resource type. Request a limit increase or delete unused resources
        /// if possible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-2018-09-24/VoteOnProposal">REST API Reference for VoteOnProposal Operation</seealso>
        Task<VoteOnProposalResponse> VoteOnProposalAsync(VoteOnProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}