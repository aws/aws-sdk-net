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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Detective.Model;

namespace Amazon.Detective
{
    /// <summary>
    /// Interface for accessing Detective
    ///
    /// <important> 
    /// <para>
    /// Amazon Detective is currently in preview. The Detective API can only be used by accounts
    /// that are admitted into the preview.
    /// </para>
    ///  </important> 
    /// <para>
    /// Detective uses machine learning and purpose-built visualizations to help you analyze
    /// and investigate security issues across your Amazon Web Services (AWS) workloads. Detective
    /// automatically extracts time-based events such as login attempts, API calls, and network
    /// traffic from AWS CloudTrail and Amazon Virtual Private Cloud (Amazon VPC) flow logs.
    /// It also extracts findings detected by Amazon GuardDuty.
    /// </para>
    ///  
    /// <para>
    /// The Detective API primarily supports the creation and management of behavior graphs.
    /// A behavior graph contains the extracted data from a set of member accounts, and is
    /// created and managed by a master account.
    /// </para>
    ///  
    /// <para>
    /// Every behavior graph is specific to a Region. You can only use the API to manage graphs
    /// that belong to the Region that is associated with the currently selected endpoint.
    /// </para>
    ///  
    /// <para>
    /// A Detective master account can use the Detective API to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Enable and disable Detective. Enabling Detective creates a new behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the list of member accounts in a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add member accounts to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove member accounts from a behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A member account can use the Detective API to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// View the list of behavior graphs that they are invited to.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Accept an invitation to contribute to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Decline an invitation to contribute to a behavior graph.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove their account from a behavior graph.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All API actions are logged as CloudTrail events. See <a href="https://docs.aws.amazon.com/detective/latest/adminguide/logging-using-cloudtrail.html">Logging
    /// Detective API Calls with CloudTrail</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonDetective : IAmazonService, IDisposable
    {
                
        #region  AcceptInvitation



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Accepts an invitation for the member account to contribute data to a behavior graph.
        /// This operation can only be called by an invited member account. 
        /// </para>
        ///  
        /// <para>
        /// The request provides the ARN of behavior graph.
        /// </para>
        ///  
        /// <para>
        /// The member account status in the graph must be <code>INVITED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraph



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Creates a new behavior graph for the calling account, and sets that account as the
        /// master account. This operation is called by the account that is enabling Detective.
        /// </para>
        ///  
        /// <para>
        /// The operation also enables Detective for the calling account in the currently selected
        /// Region. It returns the ARN of the new behavior graph.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateGraph</code> triggers a process to create the corresponding data tables
        /// for the new behavior graph.
        /// </para>
        ///  
        /// <para>
        /// An account can only be the master account for one behavior graph within a Region.
        /// If the same account calls <code>CreateGraph</code> with the same master account, it
        /// always returns the same behavior graph ARN. It does not create a new behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        Task<CreateGraphResponse> CreateGraphAsync(CreateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMembers



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Sends a request to invite the specified AWS accounts to be member accounts in the
        /// behavior graph. This operation can only be called by the master account for a behavior
        /// graph. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateMembers</code> verifies the accounts and then sends invitations to the
        /// verified accounts.
        /// </para>
        ///  
        /// <para>
        /// The request provides the behavior graph ARN and the list of accounts to invite.
        /// </para>
        ///  
        /// <para>
        /// The response separates the requested accounts into two lists:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The accounts that <code>CreateMembers</code> was able to start the verification for.
        /// This list includes member accounts that are being verified, that have passed verification
        /// and are being sent an invitation, and that have failed verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The accounts that <code>CreateMembers</code> was unable to process. This list includes
        /// accounts that were already invited to be member accounts in the behavior graph.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ServiceQuotaExceededException">
        /// This request would cause the number of member accounts in the behavior graph to exceed
        /// the maximum allowed. A behavior graph cannot have more than 1000 member accounts.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGraph



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Disables the specified behavior graph and queues it to be deleted. This operation
        /// removes the graph from each member account's list of behavior graphs.
        /// </para>
        ///  
        /// <para>
        ///  <code>DeleteGraph</code> can only be called by the master account for a behavior
        /// graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        Task<DeleteGraphResponse> DeleteGraphAsync(DeleteGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMembers



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Deletes one or more member accounts from the master account behavior graph. This operation
        /// can only be called by a Detective master account. That account cannot use <code>DeleteMembers</code>
        /// to delete their own account from the behavior graph. To disable a behavior graph,
        /// the master account uses the <code>DeleteGraph</code> API method.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateMembership



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Removes the member account from the specified behavior graph. This operation can only
        /// be called by a member account that has the <code>ENABLED</code> status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMembership service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/DisassociateMembership">REST API Reference for DisassociateMembership Operation</seealso>
        Task<DisassociateMembershipResponse> DisassociateMembershipAsync(DisassociateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMembers



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Returns the membership details for specified member accounts for a behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGraphs



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Returns the list of behavior graphs that the calling account is a master of. This
        /// operation can only be called by a master account.
        /// </para>
        ///  
        /// <para>
        /// Because an account can currently only be the master of one behavior graph within a
        /// Region, the results always contain a single graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvitations



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Retrieves the list of open and accepted behavior graph invitations for the member
        /// account. This operation can only be called by a member account.
        /// </para>
        ///  
        /// <para>
        /// Open invitations are invitations that the member account has not responded to.
        /// </para>
        ///  
        /// <para>
        /// The results do not include behavior graphs for which the member account declined the
        /// invitation. The results also do not include behavior graphs that the member account
        /// resigned from or was removed from.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMembers



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Retrieves the list of member accounts for a behavior graph. Does not return member
        /// accounts that were removed from the behavior graph.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectInvitation



        /// <summary>
        /// Amazon Detective is currently in preview.
        /// 
        ///  
        /// <para>
        /// Rejects an invitation to contribute the account data to a behavior graph. This operation
        /// must be called by a member account that has the <code>INVITED</code> status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInvitation service method, as returned by Detective.</returns>
        /// <exception cref="Amazon.Detective.Model.ConflictException">
        /// The request attempted an invalid action.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.InternalServerException">
        /// The request was valid but failed because of a problem with the service.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ResourceNotFoundException">
        /// The request refers to a nonexistent resource.
        /// </exception>
        /// <exception cref="Amazon.Detective.Model.ValidationException">
        /// The request parameters are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/detective-2018-10-26/RejectInvitation">REST API Reference for RejectInvitation Operation</seealso>
        Task<RejectInvitationResponse> RejectInvitationAsync(RejectInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}